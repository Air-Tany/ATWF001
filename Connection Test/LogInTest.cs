using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Air_Tany_Lib;
using System.Diagnostics;

namespace Connection_Test
{
    /// <summary>
    /// Description résumée pour LogInTest
    /// </summary>
    [TestClass]
    public class LogInTest
    {
        public LogInTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active, ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void submitForm()
        {
            DBConn conn;
            string _userName = "fdskqgvdksqhv";
            string _passwordHash = Common.SHA512("Respons11");
            bool _stayLogIn = false;
            string token;

            int? uid = Common.checkUserCredentials(_userName, _passwordHash, conn);
            if (uid.HasValue)
            {
                string TK = Common.createSessionToken(uid, conn);
                if (TK != null)
                {
                    token = TK;
                    Debug.Assert(token != null);
                }
            }
        }
    }
}
