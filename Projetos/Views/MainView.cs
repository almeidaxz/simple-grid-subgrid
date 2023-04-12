using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Grid;
using Projetos.ViewModels;

namespace Projetos
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        private readonly MVVMContextFluentAPI<MainViewModel> _contextFluentAPI;

        public MainView()
        {
            InitializeComponent();
            var fluent = mvvmContext1.OfType<MainViewModel>();
            mvvmContext1.ViewModelType = typeof(MainViewModel);
            _contextFluentAPI = mvvmContext1.OfType<MainViewModel>();
            _contextFluentAPI.SetBinding(gridControl1, grid => grid.DataSource, viewModel => viewModel.ListaProjetos);
        }

        private void gridView1_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            int idProjeto = (int)view.GetRowCellValue(e.RowHandle, "Id");

            _contextFluentAPI.ViewModel.FiltrarTarefasPorProjeto(idProjeto);
            _contextFluentAPI.SetBinding(e, evento => evento.ChildList, viewModel => viewModel.ListaFiltrada);
        }

        private void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {

        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "";
        }
    }
}