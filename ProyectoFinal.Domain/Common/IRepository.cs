using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.Domain.Common
{
    public interface IRepository<T> where T : class
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        T Obtener(Func<T, bool> condicion);
        IEnumerable<T> ObtenerTodos();
        void Guardar();
    }
}
