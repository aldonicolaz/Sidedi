﻿
namespace SDD.Transaction.Repositories
{
    using SDD.Model;
    using SDD.Modules.Function;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Linq;
    using MyRow = Entities.FormulirKkRow;

    public class FormulirKkRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> {
            protected override void BeforeSave()
            {
                base.BeforeSave();
                SiDedy_Default_v1Entities entities = new SiDedy_Default_v1Entities();
                int iduser = ((UserDefinition)Authorization.UserDefinition).UserId;

                int idflow = 0;
                Int64 iddesa = 0;

                try
                {
                    iddesa=(Int64) entities.Users.Where(p => p.UserId == iduser).ToList()[0].IdDesa;
                }
                catch (System.Exception e)
                {
                    iddesa = 0;
                }

                try
                {
                    idflow= entities.MasterFlowFormulirs.Where(p => p.IdDesa == iddesa && p.IdMasterForm==2).ToList()[0].IdFormFlow;
                }
                catch (System.Exception e)
                {
                    idflow = 0;
                }


                if (idflow > 0)
                {
                    Row.IdMasterFlow = idflow;
                    Row.IdUser = iduser;
                    Row.Timestamp = DateTime.Now;

                }
                else
                {
                    throw new ValidationError("Mohon pengajuan dulu ke admin");
                }
            }

            protected override void AfterSave()
            {
                base.AfterSave();
                this.Connection.GetCurrentActualTransaction().Commit();
                FunctionSidedi FunctionSidedi_ = new FunctionSidedi();
                SiDedy_Default_v1Entities entities = new SiDedy_Default_v1Entities();
                Int64 iddesa = ((UserDefinition)Authorization.UserDefinition).IdDesa;
                if (this.IsCreate)
                {
                    int iduser = ((UserDefinition)Authorization.UserDefinition).UserId;
                    int id = (int)Row.IdFormulirKk;
                    int idflow = (int)Row.IdMasterFlow;
                    int idmasterform = 0;
                    int jabatan = 0;
                    int iduseraparat = 0;
                    string kodedesa = entities.MasterDesas.Where(p => p.IdDesa == iddesa).ToList()[0].NoKodeDesa;

                    DateTime date = DateTime.Now;
                    string datetime = date.ToString("yyyyMMdd");
                    string kode = "KK" + datetime + "_" + kodedesa;
                    try
                    {
                        idmasterform = (int)entities.MasterFlowFormulirs.Where(p => p.IdFormFlow == idflow).ToList()[0].IdMasterForm;
                    }
                    catch (System.Exception e)
                    {
                        idmasterform = 0;
                    }
                    try
                    {
                        jabatan = (int)entities.viewFormFlows.Where(p => p.IdDesa == iddesa && p.IdMasterForm == 1 && p.UrutanFlow == 1).ToList()[0].IdJabatan;
                    }
                    catch (System.Exception e)
                    {
                        jabatan = 0;
                    }

                    try
                    {
                        iduseraparat = (int)entities.AparaturDesas.Where(p => p.IdJabatan == jabatan && p.IdDesa == iddesa && p.StatusAparatur == 1).ToList()[0].IdUser;
                    }
                    catch (System.Exception e)
                    {
                        iduseraparat = 0;
                    }
                    FunctionSidedi_.InsertTransaction(idmasterform, 1, iduser, "Pengajuan KK", iduseraparat, date,id);
                    string linkpdf = FunctionSidedi_.FormKK(id, date, kode);

                    FormulirKK FormulirKK_ = (from e1 in entities.FormulirKKs where e1.IdFormulirKK == id select e1).First();
                    FormulirKK_.LinkDocKK = linkpdf;

                    entities.SaveChanges();

                  
                }
                if (this.IsUpdate)
                {
                    int iduser = ((UserDefinition)Authorization.UserDefinition).UserId;
                    int id = (int)Row.IdFormulirKk;
                    string kodedesa = entities.ViewFormKKs.Where(p => p.IdFormulirKK == id).ToList()[0].NoKodeDesa;

                    DateTime date = DateTime.Now;
                    string datetime = date.ToString("yyyyMMdd");
                    string kode = "KK" + datetime + "_" + kodedesa;
                    string linkpdf = FunctionSidedi_.FormKK(id, date, kode);

                    FormulirKK FormulirKK_ = (from e1 in entities.FormulirKKs where e1.IdFormulirKK == id select e1).First();
                    FormulirKK_.LinkDocKK = linkpdf;

                    entities.SaveChanges();
                }
            }
        }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        private class MyListHandler : ListRequestHandler<MyRow> {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);

                var iduser = ((UserDefinition)Authorization.UserDefinition).UserId;
                int RoleId = 0;
                try
                {
                    RoleId = ((UserDefinition)Serenity.Authorization.UserDefinition).Roles[0].RoleId;
                }
                catch (System.Exception e)
                {
                    RoleId = 0;
                }

                if (iduser == 1)
                {

                }
                else
                {

                    query.Where(fld.IdUser == iduser);



                }



            }
        }
    }
}