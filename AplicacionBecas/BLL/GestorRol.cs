using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;
using System.Collections;


namespace BLL
{
    public class GestorRol
    {

        /// <summary>
        /// Este metodo crea un nuevo rol
        /// </summary>
        /// <param name="pnombre">Nombre del rol</param>
        public void agregarRol(string pnombre)
        {
            try
            {

                Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
                //if (objRol.IsValid)
                //{
                RolRepository.Instance.Insert(objRol);
                //    }
                //    else
                //    {
                //        StringBuilder sb = new StringBuilder();
                //        foreach (RuleViolation rv in objMusculo.GetRuleViolations())
                //        {
                //            sb.AppendLine(rv.ErrorMessage);
                //        }
                //        throw new ApplicationException(sb.ToString());
                //    }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Modifica el rol
        /// </summary>
        /// <param name="pnombre">nombre del rol a modificar</param>
        public void modificarRol(string pnombre)
        {

            Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
            RolRepository.Instance.Update(objRol);

        }
        /// <summary>
        /// Elimina un rol
        /// </summary>
        /// <param name="pnombre">nombre del rol a modificar</param>
        public void eliminarRol(String pnombre)
        {
            /////////////////////////////////////
            Rol objRol = ContenedorMantenimiento.Instance.crearObjetoRol(pnombre);
            //Rol objRol = new Rol { Id = idRol };
            RolRepository.Instance.Delete(objRol);
        }

        /// <summary>
        /// Consultar los roles
        /// </summary>
        /// <returns>Retorna una lista de roles</returns>
        public IEnumerable<Rol> consultarRoles()
        {
            return RolRepository.Instance.GetAll();
        }

        /// <summary>
        /// Consulta los permisos
        /// </summary>
        /// <returns>Retorna una lista de permisos</returns>
        public IEnumerable<Permiso> consultarPermisos()
        {
            return PermisoRepository.Instance.GetAll();
        }

        /// <summary>
        /// Consulta un rol por el nombre
        /// </summary>
        /// <param name="pnombre">Nombre del rol a consultar</param>
        /// <returns>El rol digitado</returns>
        public Rol consultarRolPorNombre(String pnombre)
        {
            return RolRepository.Instance.GetByNombre(pnombre);
        }


        /// <summary>
        /// Guarda los datos 
        /// </summary>
        public void guardarCambios()
        {
            //try
            //{
            RolRepository.Instance.Save();
            //    }
            //    catch (DataAccessException ex)
            //    {
            //        throw ex;
            //    }
            //    catch (Exception ex)
            //    {
            //        //logear a la bd
            //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //    }
        }



    }
}
