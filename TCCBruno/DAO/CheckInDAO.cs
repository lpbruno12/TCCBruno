using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data.SqlClient;
using System.Data;
using TCCBruno.Model;

namespace TCCBruno.DAO
{
    public class CheckInDAO
    {

        //public List<Treino> LoadTreinos(int alunoId)
        //{
        //    string queryString = "SELECT [treino_id], [data_inicio], [data_fim]" +
        //                            " FROM Treino" +
        //                            " WHERE [aluno_id] = @paluno_id";

        //    List<SqlParameter> parametersList = new List<SqlParameter>()
        //    {
        //        new SqlParameter() {ParameterName="@paluno_id", SqlDbType = SqlDbType.Int, Value = alunoId }
        //    };

        //    return DBConnection.SelectQuery<Treino>(queryString, parametersList);
        //}

        public bool InsertCheckIn(CheckIn checkin)
        {

            string queryString = "INSERT INTO [dbo].[Checkin] ([aluno_id], [treino_tipo_id], [data_checkin])" +
                                    " VALUES (@paluno_id, @ptreino_tipo_id, @pdata_checkin)";
            List<SqlParameter> parametersList = new List<SqlParameter>()
            {
                new SqlParameter() {ParameterName="@paluno_id", SqlDbType = SqlDbType.Int, Value = checkin.aluno_id },
                new SqlParameter() {ParameterName="@ptreino_tipo_id", SqlDbType = SqlDbType.Int, Value = checkin.treino_tipo_id },
                new SqlParameter() {ParameterName="@pdata_checkin", SqlDbType = SqlDbType.DateTime, Value = checkin.data_checkin }
            };

            return DBConnection.InsertQuery(queryString, parametersList);
        }
    }
}