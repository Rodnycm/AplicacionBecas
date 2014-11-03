using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using DAL;


namespace BLL
{
    public class GestorCurso
    {



        //<summary> Método que se encarga de crear un nuevo Curso</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param name = "nombre"> variable de tipo String que almacena nombre del curso</param>
        //<param name= "codigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "cuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso  </param>
        //<param name = " creditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "precio"> variable de tipo String que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 


        public void agregarCurso(string nombre, string codigo, string cuatrimestre, int creditos, double precio)
        {

            try
            {
                Curso objCurso = new Curso(nombre, codigo, cuatrimestre, creditos, precio);
                //if (objCurso.IsValid)
                //{
                CursoRepository.Instance.Insert(objCurso);
                //}
                //else
                //{
                //    StringBuilder sb = new StringBuilder();
                //    foreach (RuleViolation rv in objCurso.GetRuleViolations())
                //    {
                //        sb.AppendLine(rv.ErrorMessage);
                //    }
                //    throw new ApplicationException(sb.ToString());
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        //<summary> Método que se encarga de buscar todos los cursos que existen en el sistema</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param > No recibe parámetros  </param>
        //<returns> Retorna una lista con los cursos registrados</returns> 
        public IEnumerable<Curso> listarCursos()
        {
            return CursoRepository.Instance.GetAll();
        }



        //<summary> Método que se encarga de buscar un curso en específico</summary>
        //<author>Valeria Ramírez Cordero</author> 
        //<param name = "parametro">variable de tipo String que almacena el nombre o el código del curso </param>
        //<returns> Retorna el curso buscado</returns> 
        public Curso BuscarCurso(String pparametro){
           

            return CursoRepository.Instance.GetByNombre(pparametro);

        }


        //public void eliminarProducto(int idHueso){

        //    Hueso objHueso = new Hueso { Id = idHueso };
        //    UoW.HuesoRepository.Delete(objHueso);
        //}





        //<summary> Método que se encarga de modificar un Curso</summary>
        //<author> Valeria Ramírez Cordero</author> 
        //<param name = "nombre"> variable de tipo String que almacena nombre del curso</param>
        //<param name= "codigo" > variable de tipo String que almacena el código del curso </param>
        //<param name = "cuatrimestre"> variable de tipo String que almacena el cuatrimestre en el que se encuentra el curso  </param>
        //<param name = " creditos"> variable de tipo int que almacena los créditos del curso</param>
        //<param name = "precio"> variable de tipo String que almacena el precio del curso</param>
        //<returns> No retorna valor.</returns> 

        public void modificarCurso(String pcodigo, String pnombre, String pcuatrimestre, int pcreditos, double pprecio, int pIdCurso)
        {

            try{
                Curso objetoCurso = ContenedorMantenimiento.Instance.crearObjetoCurso(pcodigo, pnombre, pcuatrimestre, pcreditos, pIdCurso);
            }
            catch (Exception ex){

                throw ex;
            }
        }

        //public void eliminarProducto(int idHueso)
        //{

        //    Hueso objHueso = new Hueso { Id = idHueso };
        //    UoW.HuesoRepository.Delete(objHueso);
        //}




        //public IEnumerable<Curso> consultarCurso()
        //{
        //    return CursoRepository.Instance.GetAll();
        //}

        //public Hueso consultarHuesoXID(int id)
        //{
        //    return UoW.HuesoRepository.GetById(id);
        //}




        //<summary> Método que se encarga de guardar los cambios de un curso</summary>
        //<author> Valeria Ramírez Cordero </author> 
        //<param> No recibe parametros  </param>
        //<returns> No retorna valor </returns> 
        public void guardarCambios()
        {

            CursoRepository.Instance.Save();
            //try
            //{

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


