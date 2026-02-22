using CommunityToolkit.Mvvm.ComponentModel;
using DirectorioMAUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DirectorioMAUI.PagesModels;

public partial class DetailsPageModel : ObservableObject
{
    [ObservableProperty]
    private object _data;

    [ObservableProperty]
    private bool _isEmpleado;

    [ObservableProperty]
    private bool _isDepartamento;

    partial void OnDataChanged(object value)
    {
        IsEmpleado = value is Empleado;
        IsDepartamento = value is Departamento;
    }
}
