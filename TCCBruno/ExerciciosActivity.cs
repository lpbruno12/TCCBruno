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
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace TCCBruno
{
    [Activity(Label = "Exerc�cios")]
    public class ExerciciosActivity : ActivityBase
    {
        //private GridLayout _gridLayout;
        //private int _instrutorId;
        private ExpandableListView _exerciciosList;
        //private ListView _treinosListView;
        Dictionary<string, int> _instrutorAlunoDict = new Dictionary<string, int>();
        private int _treinoId;

        public NavigationService Nav
        {
            get
            {
                return (NavigationService)ServiceLocator.Current
                    .GetInstance<INavigationService>();
            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ExerciciosPage);

            _exerciciosList = FindViewById<ExpandableListView>(Resource.Id.LV_Exercicios);
            //_treinosListView = FindViewById<ListView>(Resource.Id.LV_Treinos);

            //_exerciciosList.ItemClick += LV_Treinos_ItemClick;
            //FindViewById<Button>(Resource.Id.BTN_NovoTreino).Click += BTN_NovoTreino_Click; ;

            //Recebe o Id do usu�rio (instrutor) logado no sistema por passagem de par�metro da tela anterior
            //_instrutorAlunoDict = Nav.GetAndRemoveParameter<Dictionary<string, int>>(Intent);
            _treinoId = Nav.GetAndRemoveParameter<int>(Intent);
        }

        private void LoadExercicios()
        {
            //TreinoDAO treinoDAO = new TreinoDAO();
            //var treinosList = treinoDAO.LoadTreinos(_instrutorAlunoDict["aluno_id"]);
            //if (treinosList == null)
            //{
            //    Validation.DisplayAlertMessage("Falha ao carregar Treinos", this);
            //    return;
            //}

            ////Para cada Treino, carregar o seu treino Tipo:
            //Treino_TipoDAO treinoTipoDAO = new Treino_TipoDAO();
            //foreach (var treino in treinosList)
            //{
            //    treino.Treino_Tipo = treinoTipoDAO.LoadTreino_Tipos(treino.treino_id);
            //}

            ////Preence ListView com os Treinos do Aluno
            //var listAdapter = new TreinosExpandableListAdapter(this, treinosList);
            //_exerciciosList.SetAdapter(listAdapter);

            ////var listAdapter = new TreinosAdapter(this, treinosList);
            ////_treinosListView.Adapter = listAdapter;
        }

        private void BTN_NovoTreino_Click(object sender, EventArgs e)
        {
            //Nav.NavigateTo("CadastroExercicioPage", _instrutorAlunoDict);
        }



        /// <summary>
        /// Ao voltar a esta tela, carrega os treinos novamente do BD
        /// </summary>
        protected override void OnResume()
        {
            base.OnResume();
            //LoadTreinos();
        }
    }
}