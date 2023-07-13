using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyProtocolsApp_Allan.Models;

namespace MyProtocolsApp_Allan.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        //el VM funciona como puente entre el modelo y la vista 
        //en sentido teórico el vm "siente" los cambios de la vista 
        //y los pasa al modelo de forma automática, o viceversa
        //según se use en uno o dos sentidos. 

        //también se puede usar (como en este caso particular, 
        //simplemente como mediador de procesos. Más adelante se usará 
        //commands y bindings en dos sentidos 

        //primero en formato de funciones clásicas
        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUser = new User();
        }

        //funciones 

        //función para validar el ingreso del usuario al app por medio del 
        //login 

        public async Task<bool> UserAccessValidation(string pEmail, string pPassword)
        { 
            //debemos poder controlar que no se ejecute la operación más de una vez 
            //en este caso hay una funcionalidad pensada para eso en BaseViewModel que 
            //fue heredada al definir esta clase. 
            //Se usará una propiedad llamada "IsBusy" para indicar que está en proceso de ejecución
            //mientras su valor sea verdadero 

            //control de bloqueo de funcionalidad 
            if (IsBusy) return false;
            IsBusy = true;

            try
            {
                MyUser.Email = pEmail;
                MyUser.Password = pPassword;

                bool R = await MyUser.ValidateUserLogin();

                return R;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

                return false;

                throw;
            }
            finally
            {
                IsBusy = false; 
            }
        }


    }
}
