using CommunityToolkit.Mvvm.ComponentModel;
using VisioAlerta.App.Models;

namespace VisioAlerta.App.ViewModels;

public partial class DashboardViewModel : ObservableObject
{
    [ObservableProperty]
    private Alerta alertaActual;

    public DashboardViewModel()
    {
        AlertaActual = new Alerta
        {
            Paciente = "Ismael",
            FuerzaImpactoG = 8,
            Estado = "Monitoreando..."
        };
    }
}