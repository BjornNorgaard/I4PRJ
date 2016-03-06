using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace ModelFirstSmartPool
{
    public class DatabaseAccessControl
    {
        public void AddUserToDatabase(User user)
        {
            using (var db = new SmartPoolContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void ClearAllEntitiesInDatabase()
        {
            using (var db = new SmartPoolContext())
            {
                Console.WriteLine("This action wil clear the entire SmartPool user database (yes/no).");

                if (SecurityCheck() == true)
                {

                    //These commands need to be parameterized
                    db.Database.ExecuteSqlCommand("DELETE [MonitorUnits]");
                    Console.WriteLine("Clearing MonitorUnits...");

                    db.Database.ExecuteSqlCommand("DELETE [Pools]");
                    Console.WriteLine("Clearing pools...");

                    db.Database.ExecuteSqlCommand("DELETE [UserEntities]");
                    Console.WriteLine("Clearing UserEntities...");

                    db.Database.ExecuteSqlCommand("DELETE [RealNames]");
                    Console.WriteLine("Clearing RealNames");
                    Console.WriteLine("************************************************************");
                    Console.WriteLine("******************** All tables cleared! *******************");

                    db.SaveChanges();
                }
                else
                {
                    return;
                }
            }
        }

        public bool SecurityCheck()
        {
            var securityCheck = Console.ReadLine(/* yes/no */);

            if (securityCheck == "yes")
            {
                return true;
            }
            else if (securityCheck == "no")
            {
                Console.WriteLine("Please be more careful. Returning to main menu");
                return false;
            }
            else
            {
                return false;
            }
        }

        public void ClearMonitorUnitEntity()
        {
            using (var db = new SmartPoolContext())
            {
                Console.WriteLine("This action wil clear the entire MonitorUnit entity in the user database (yes/no).");
                if (SecurityCheck() == true)
                {
                    db.Database.ExecuteSqlCommand("DELETE [MonitorUnits]");
                    Console.WriteLine("DELETE [MonitorUnits] run against database: db");
                    Console.WriteLine("MonitorUnits was deletes succesfully");
                }
                else
                {
                    return;
                }
            }
        }
    }
}