using System;

namespace SRPejemplos
{
    public class AdministradorMiembro
    {
        public void Aumentar(Miembro miembro)
        {
            //aqui va el codigo
        }
        public void Aumentar(string nombre,string apellido,string cedula)
        {
            try
            {
                System.IO.File.AppendAllText("\\datos\\data.txt", 
                    string.Format("nombre:{0},apellido:{1},cedula:{2}", nombre, apellido, cedula));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Fail(ex.Message);
            }
        }
         
        public void Eliminar(string cedula)
        {
            //aqui va el codigo
        }
    }
    
}
