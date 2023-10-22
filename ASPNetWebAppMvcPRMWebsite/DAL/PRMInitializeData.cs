using ASP.NETCorePRMWebsite.Models;
using ASPNetWebAppMvcPRMWebsite.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPNetWebAppMvcPRMWebsite.DAL
{
    public class PRMInitializeData : System.Data.Entity.DropCreateDatabaseIfModelChanges<PRMContext>
    {
        protected override void Seed(PRMContext prmContext)
        {
                     
            var owner = new List<Owner>
            {
                new Owner{OwnerId=12341,FirstName="Mary",LastName="Brown",Email="mary@hotmail.com",Phone="3647584859", Password="mary1234"},
                new Owner{OwnerId=12342,FirstName="Marie",LastName="Brown",Email="marie@yahoo.com",Phone="4647584858", Password="marie1234"},
                new Owner{OwnerId=12343,FirstName="Thomas",LastName="Moore",Email="thomas@gmail.com",Phone="5647584857", Password="thomas1234"},
                new Owner{OwnerId=12344,FirstName="Jennifer",LastName="Green",Email="jennifer@yahoo.ca",Phone="6647584856", Password="jennifer1234"},
                new Owner{OwnerId=12345,FirstName="Mary",LastName="Green",Email="maryGreen@yahoo.com",Phone="7647584855", Password="green1234"}
            };
            owner.ForEach(s => prmContext.Owners.Add(s));
            prmContext.SaveChanges();

            var propertyManager = new List<PropertyManager>
            {
                new PropertyManager{PropertyManagerId=11111,FirstName="Rafael",LastName="Campos",Email="rafael@hotmail.com",Phone="8495930495", Password="rafael1234"},
                new PropertyManager{PropertyManagerId=22222,FirstName="Joao",LastName="Souza",Email="joao@yahoo.com",Phone="7495930496", Password="joao1234"},
                new PropertyManager{PropertyManagerId=33333,FirstName="Fernando",LastName="Santos",Email="fernando@gmail.com",Phone="6495930497", Password="fernando1234"},
                new PropertyManager{PropertyManagerId=44444,FirstName="Francisco",LastName="Peres",Email="francisco@yahoo.ca",Phone="5647584858", Password="francisco1234"},
                new PropertyManager{PropertyManagerId=55555,FirstName="Jose",LastName="Silza",Email="jose@yahoo.com",Phone="4647584859", Password="jose1234"}
            };
            propertyManager.ForEach(s => prmContext.PropertyManagers.Add(s));
            prmContext.SaveChanges();

            var tenant = new List<Tenant>
            {
                new Tenant{TenantId=98761,FirstName="Pablo",LastName="Prince",Email="pablo@hotmail.com",Phone="7495839406", Password="pablo1234"},
                new Tenant{TenantId=98762,FirstName="Victor",LastName="Alves",Email="victor@yahoo.com",Phone="6495839407", Password="victor1234"},
                new Tenant{TenantId=98763,FirstName="Diana",LastName="Santos",Email="diana@gmail.com",Phone="5495839408", Password="diana1234"},
                new Tenant{TenantId=98764,FirstName="Alfredo",LastName="Sanches",Email="alfredo@yahoo.ca",Phone="4495839409", Password="alfredo1234"},
                new Tenant{TenantId=98765,FirstName="Bruno",LastName="Silva",Email="bruno@yahoo.com",Phone="3495839400", Password="bruno1234"}
            };
            tenant.ForEach(s => prmContext.Tenants.Add(s));
            prmContext.SaveChanges();


            var user = new List<User>
            {
                new User{UserId=12341,Password="mary1234", Role="Owner"},
                new User{UserId=12342,Password="marie1234", Role="Owner"},
                new User{UserId=12343,Password="thomas1234", Role="Owner"},
                new User{UserId=12344,Password="jennifer1234", Role="Owner"},
                new User{UserId=12345,Password="green1234", Role="Owner"},
                new User{UserId=11111,Password="rafael1234", Role="Property Manager"},
                new User{UserId=22222,Password="joao1234", Role="Property Manager"},
                new User{UserId=33333,Password="fernando1234", Role="Property Manager"},
                new User{UserId=44444,Password="francisco1234", Role="Property Manager"},
                new User{UserId=55555,Password="jose1234", Role="Property Manager"},
                new User{UserId=98761,Password="pablo1234", Role="Tenant"},
                new User{UserId=98762,Password="victor1234", Role="Tenant"},
                new User{UserId=98763,Password="diana1234", Role="Tenant"},
                new User{UserId=98764,Password="alfredo1234", Role="Tenant"},
                new User{UserId=98765,Password="bruno1234", Role="Tenant"}
            };
            user.ForEach(s => prmContext.Users.Add(s));
            prmContext.SaveChanges();


            var building = new List<Building>
            {
                new Building{BuildingId=353,Description="Big",UnitNumber=123,Location="Montreal"},
                new Building{BuildingId=545,Description="Small",UnitNumber=124,Location="Montreal West"},
                new Building{BuildingId=657,Description="Central",UnitNumber=125,Location="Laval"},
                new Building{BuildingId=786,Description="Hot",UnitNumber=126,Location="Longueil"},
                new Building{BuildingId=879,Description="Cold",UnitNumber=127,Location="Montreal Est"}
            };
            building.ForEach(s => prmContext.Buildings.Add(s));
            prmContext.SaveChanges();


            var apartment = new List<Apartment>
            {
                new Apartment{ApartmentId=123,BuildingId=353,OwnerId = 12341, PropertyManagerId=11111,ApartmentUnitNumber=201,Description="Big", Size=5, Price=2400, Status="Available"},
                new Apartment{ApartmentId=124,BuildingId=545,OwnerId = 12342, PropertyManagerId=22222,ApartmentUnitNumber=301,Description="Small", Size=4, Price=2300, Status="Available"},
                new Apartment{ApartmentId=125,BuildingId=657,OwnerId = 12343, PropertyManagerId=33333,ApartmentUnitNumber=401,Description="Central", Size=3, Price=2200, Status="Available"},
                new Apartment{ApartmentId=126,BuildingId=786,OwnerId = 12344, PropertyManagerId=44444,ApartmentUnitNumber=501,Description="Hot", Size=2, Price=2100, Status="Available"},
                new Apartment{ApartmentId=127,BuildingId=879,OwnerId = 12345, PropertyManagerId=55555,ApartmentUnitNumber=601,Description="Cold", Size=2, Price=2120, Status="Available"}

            };
            apartment.ForEach(s => prmContext.Apartments.Add(s));
            prmContext.SaveChanges();


            var appointment = new List<Appointment>
            {
                new Appointment{AppointmentId=123,ApartmentId=123,TenantId=98761, CreateDate =DateTime.Parse("4/5/2023"), Status="Confirmed"},
                new Appointment{AppointmentId=124,ApartmentId=124,TenantId=98762, CreateDate=DateTime.Parse("4/5/2023"), Status="Confirmed"},
                new Appointment{AppointmentId=125,ApartmentId=125,TenantId=98763, CreateDate=DateTime.Parse("4/5/2023"), Status="Confirmed"}

            };
            appointment.ForEach(s => prmContext.Appointments.Add(s));
            prmContext.SaveChanges();


            var message = new List<Message>
            {
                new Message{MessageId=345,ApartmentId=123,MessageText="Good",TenantId=98761,CreateDate =DateTime.Parse("4/6/2023"), SentBy="Tenant"},
                new Message{MessageId=346,ApartmentId=124,MessageText="Response Property Manager",TenantId=98762, CreateDate=DateTime.Parse("4/7/2023"), SentBy="Property Manager"},
                new Message{MessageId=347,ApartmentId=125,MessageText="Nice",TenantId=98763, CreateDate=DateTime.Parse("4/8/2023"), SentBy="Confirmed"}

            };
            message.ForEach(s => prmContext.Messages.Add(s));
            prmContext.SaveChanges();


            var reportEvent = new List<ReportEvent>
            {
                new ReportEvent{ReportEventId=845,ApartmentId=123,EventText="Door Problem",CreateDate =DateTime.Parse("4/2/2023")},
                new ReportEvent{ReportEventId=846,ApartmentId=124,EventText="Repair Window",CreateDate=DateTime.Parse("4/4/2023")},
                new ReportEvent{ReportEventId=847,ApartmentId=125,EventText="Change the key", CreateDate=DateTime.Parse("4/6/2023")}

            };
            reportEvent.ForEach(s => prmContext.ReportEvents.Add(s));
            prmContext.SaveChanges();


            var scheduleAppointment = new List<ScheduleAppointment>
            {
                new ScheduleAppointment{ScheduleAppointmentId=239,PropertyManagerId=11111,TenantId=98761, ScheduleAppointmentDate =DateTime.Parse("4/4/2023"), Status="Confirmed"},
                new ScheduleAppointment{ScheduleAppointmentId=241,PropertyManagerId=22222,TenantId=98762, ScheduleAppointmentDate=DateTime.Parse("4/5/2023"), Status="Confirmed"},
                new ScheduleAppointment{ScheduleAppointmentId=242,PropertyManagerId=33333,TenantId=98763, ScheduleAppointmentDate=DateTime.Parse("4/7/2023"), Status="Confirmed"}

            };
            scheduleAppointment.ForEach(s => prmContext.ScheduleAppointments.Add(s));
            prmContext.SaveChanges();

        }
    }
}