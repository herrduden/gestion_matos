using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppMatosGestion.Entities;

namespace WindowsFormsAppMatosGestion.Session
{
    internal class Session
    {
        private static Session instance = null ;
        private Utilisateur User;

        private Session (Utilisateur loggedUser) { 
            
            User= loggedUser;
        }
        
        public static bool OpenSession(Utilisateur loggedUser)
        {
            if (instance == null)
            {
                instance= new Session (loggedUser);
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static Session GetSession()
        {
            return instance;
        }

        public Utilisateur GetUtilisateur()
        {
            return User;
        }

        public void CloseSession()
        {
            instance = null;
        }


    }
}
