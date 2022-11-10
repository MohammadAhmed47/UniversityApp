using markustei.BL;
using markustei.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace markustei.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string errormsg = "", string sucmsg = "")
        {
            List<UserPost> UserPost = new UserPostBL().GetActiveUserPostList().OrderByDescending(x => x.Id).ToList();
            ViewBag.UserPost = UserPost;
            ViewBag.errormsg = errormsg;
            ViewBag.successfullmsg = sucmsg;
            return View();
        }

        public ActionResult PostAddUserPosts(UserPost UserPost, HttpPostedFileBase Picture, string[] CheckedCourses, string[] CSModules, string[] EngineeringModules,
            string[] TeachingModules, string[] BiologyModules, string[] GeographyModules, string[] MathsModules, string[] CommunicationModules, string[] ChemistryModules,
            string[] PhysicsModules, string[] LawModules, string[] EconomicsModules, string[] BusinessModules, string[] MusicModules, string[] ArchitectureModules,
            string[] EnglishModules, string[] DentistryModules, string[] MarineScienceModules, string[] MedicineModules, string[] AccountingModules, string[] AnthropologyModules)
        {
            string Courses = "";
            string GetCourses = "";
            string CSModule = "";
            string GetCSModules = "";
            string EModule = "";
            string GetEModules = "";
            string TModule = "";
            string GetTModules = "";
            string BioModule = "";
            string GetBioModules = "";
            string GeoModule = "";
            string GetGeoModules = "";
            string MaModule = "";
            string GetMaModules = "";
            string ComModule = "";
            string GetComModules = "";
            string CheModule = "";
            string GetCheModules = "";
            string PhyModule = "";
            string GetPhyModules = "";
            string LawModule = "";
            string GetLawModules = "";
            string EcoModule = "";
            string GetEcoModules = "";
            string BusModule = "";
            string GetBusModules = "";
            string MusModule = "";
            string GetMusModules = "";
            string ArchModule = "";
            string GetArchModules = "";
            string EngModule = "";
            string GetEngModules = "";
            string DenModule = "";
            string GetDenModules = "";
            string MSModule = "";
            string GetMSModules = "";
            string MedModule = "";
            string GetMedModules = "";
            string AccModule = "";
            string GetAccModules = "";
            string AntModule = "";
            string GetAntModules = "";
            if (CheckedCourses != null)
            {
                if (CheckedCourses.Length > 1)
                {
                    foreach (var item in CheckedCourses)
                    {
                        Courses = item;
                        if (GetCourses == "")
                        {
                            GetCourses = Courses;
                        }
                        else
                        {
                            GetCourses = GetCourses + "/" + Courses;
                        }
                    }
                }
                else
                {
                    foreach (var item in CheckedCourses)
                    {
                        Courses = item;
                    }
                    GetCourses = Courses;
                }
            }
            else
            {
                GetCourses = Courses;
            }

            if(CSModules != null)
            {
                if (CSModules.Length > 1)
                {
                    foreach (var item in CSModules)
                    {
                        CSModule = item;
                        if (GetCSModules == "")
                        {
                            GetCSModules = CSModule;
                        }
                        else
                        {
                            GetCSModules = GetCSModules + "/" + CSModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in CSModules)
                    {
                        CSModule = item;
                    }
                    GetCSModules = CSModule;
                }
            }
            else
            {
                GetCSModules = CSModule;
            }

            if (EngineeringModules != null)
            {
                if (EngineeringModules.Length > 1)
                {
                    foreach (var item in EngineeringModules)
                    {
                        EModule = item;
                        if (GetEModules == "")
                        {
                            GetEModules = EModule;
                        }
                        else
                        {
                            GetEModules = GetEModules + "/" + EModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in EngineeringModules)
                    {
                        EModule = item;
                    }
                    GetEModules = EModule;
                }
            }
            else
            {
                GetEModules = EModule;
            }

            if (TeachingModules != null)
            {
                if (TeachingModules.Length > 1)
                {
                    foreach (var item in TeachingModules)
                    {
                        TModule = item;
                        if (GetTModules == "")
                        {
                            GetTModules = TModule;
                        }
                        else
                        {
                            GetTModules = GetTModules + "/" + TModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in TeachingModules)
                    {
                        TModule = item;
                    }
                    GetTModules = TModule;
                }
            }
            else
            {
                GetTModules = TModule;
            }

            if (BiologyModules != null)
            {
                if (BiologyModules.Length > 1)
                {
                    foreach (var item in BiologyModules)
                    {
                        BioModule = item;
                        if (GetBioModules == "")
                        {
                            GetBioModules = BioModule;
                        }
                        else
                        {
                            GetBioModules = GetBioModules + "/" + BioModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in BiologyModules)
                    {
                        BioModule = item;
                    }
                    GetBioModules = BioModule;
                }
            }
            else
            {
                GetBioModules = BioModule;
            }

            if (GeographyModules != null)
            {
                if (GeographyModules.Length > 1)
                {
                    foreach (var item in GeographyModules)
                    {
                        GeoModule = item;
                        if (GetGeoModules == "")
                        {
                            GetGeoModules = GeoModule;
                        }
                        else
                        {
                            GetGeoModules = GetGeoModules + "/" + GeoModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in GeographyModules)
                    {
                        GeoModule = item;
                    }
                    GetGeoModules = GeoModule;
                }
            }
            else
            {
                GetGeoModules = GeoModule;
            }

            if (MathsModules != null)
            {
                if (MathsModules.Length > 1)
                {
                    foreach (var item in MathsModules)
                    {
                        MaModule = item;
                        if (GetMaModules == "")
                        {
                            GetMaModules = MaModule;
                        }
                        else
                        {
                            GetMaModules = GetMaModules + "/" + MaModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in MathsModules)
                    {
                        MaModule = item;
                    }
                    GetMaModules = MaModule;
                }
            }
            else
            {
                GetMaModules = MaModule;
            }

            if (CommunicationModules != null)
            {
                if (CommunicationModules.Length > 1)
                {
                    foreach (var item in CommunicationModules)
                    {
                        ComModule = item;
                        if (GetComModules == "")
                        {
                            GetComModules = ComModule;
                        }
                        else
                        {
                            GetComModules = GetComModules + "/" + ComModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in CommunicationModules)
                    {
                        ComModule = item;
                    }
                    GetComModules = ComModule;
                }
            }
            else
            {
                GetComModules = ComModule;
            }

            if (ChemistryModules != null)
            {
                if (ChemistryModules.Length > 1)
                {
                    foreach (var item in ChemistryModules)
                    {
                        CheModule = item;
                        if (GetCheModules == "")
                        {
                            GetCheModules = CheModule;
                        }
                        else
                        {
                            GetCheModules = GetCheModules + "/" + CheModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in ChemistryModules)
                    {
                        CheModule = item;
                    }
                    GetCheModules = CheModule;
                }
            }
            else
            {
                GetCheModules = CheModule;
            }

            if (PhysicsModules != null)
            {
                if (PhysicsModules.Length > 1)
                {
                    foreach (var item in PhysicsModules)
                    {
                        PhyModule = item;
                        if (GetPhyModules == "")
                        {
                            GetPhyModules = PhyModule;
                        }
                        else
                        {
                            GetPhyModules = GetPhyModules + "/" + PhyModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in PhysicsModules)
                    {
                        PhyModule = item;
                    }
                    GetPhyModules = PhyModule;
                }
            }
            else
            {
                GetPhyModules = PhyModule;
            }

            if (LawModules != null)
            {
                if (LawModules.Length > 1)
                {
                    foreach (var item in LawModules)
                    {
                        LawModule = item;
                        if (GetLawModules == "")
                        {
                            GetLawModules = LawModule;
                        }
                        else
                        {
                            GetLawModules = GetLawModules + "/" + LawModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in LawModules)
                    {
                        LawModule = item;
                    }
                    GetLawModules = LawModule;
                }
            }
            else
            {
                GetLawModules = LawModule;
            }

            if (EconomicsModules != null)
            {
                if (EconomicsModules.Length > 1)
                {
                    foreach (var item in EconomicsModules)
                    {
                        EcoModule = item;
                        if (GetEcoModules == "")
                        {
                            GetEcoModules = EcoModule;
                        }
                        else
                        {
                            GetEcoModules = GetEcoModules + "/" + EcoModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in EconomicsModules)
                    {
                        EcoModule = item;
                    }
                    GetEcoModules = EcoModule;
                }
            }
            else
            {
                GetEcoModules = EcoModule;
            }

            if (BusinessModules != null)
            {
                if (BusinessModules.Length > 1)
                {
                    foreach (var item in BusinessModules)
                    {
                        BusModule = item;
                        if (GetBusModules == "")
                        {
                            GetBusModules = BusModule;
                        }
                        else
                        {
                            GetBusModules = GetBusModules + "/" + BusModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in BusinessModules)
                    {
                        BusModule = item;
                    }
                    GetBusModules = BusModule;
                }
            }
            else
            {
                GetBusModules = BusModule;
            }

            if (MusicModules != null)
            {
                if (MusicModules.Length > 1)
                {
                    foreach (var item in MusicModules)
                    {
                        MusModule = item;
                        if (GetMusModules == "")
                        {
                            GetMusModules = MusModule;
                        }
                        else
                        {
                            GetMusModules = GetMusModules + "/" + MusModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in MusicModules)
                    {
                        MusModule = item;
                    }
                    GetMusModules = MusModule;
                }
            }
            else
            {
                GetMusModules = MusModule;
            }

            if (ArchitectureModules != null)
            {
                if (ArchitectureModules.Length > 1)
                {
                    foreach (var item in ArchitectureModules)
                    {
                        ArchModule = item;
                        if (GetArchModules == "")
                        {
                            GetArchModules = ArchModule;
                        }
                        else
                        {
                            GetArchModules = GetArchModules + "/" + ArchModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in ArchitectureModules)
                    {
                        ArchModule = item;
                    }
                    GetArchModules = ArchModule;
                }
            }
            else
            {
                GetArchModules = ArchModule;
            }

            if (EnglishModules != null)
            {
                if (EnglishModules.Length > 1)
                {
                    foreach (var item in EnglishModules)
                    {
                        EngModule = item;
                        if (GetEngModules == "")
                        {
                            GetEngModules = EngModule;
                        }
                        else
                        {
                            GetEngModules = GetEngModules + "/" + EngModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in EnglishModules)
                    {
                        EngModule = item;
                    }
                    GetEngModules = EngModule;
                }
            }
            else
            {
                GetEngModules = EngModule;
            }

            if (DentistryModules != null)
            {
                if (DentistryModules.Length > 1)
                {
                    foreach (var item in DentistryModules)
                    {
                        DenModule = item;
                        if (GetDenModules == "")
                        {
                            GetDenModules = DenModule;
                        }
                        else
                        {
                            GetDenModules = GetDenModules + "/" + DenModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in DentistryModules)
                    {
                        DenModule = item;
                    }
                    GetDenModules = DenModule;
                }
            }
            else
            {
                GetDenModules = DenModule;
            }

            if (MarineScienceModules != null)
            {
                if (MarineScienceModules.Length > 1)
                {
                    foreach (var item in MarineScienceModules)
                    {
                        MSModule = item;
                        if (GetMSModules == "")
                        {
                            GetMSModules = MSModule;
                        }
                        else
                        {
                            GetMSModules = GetMSModules + "/" + MSModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in MarineScienceModules)
                    {
                        MSModule = item;
                    }
                    GetMSModules = MSModule;
                }
            }
            else
            {
                GetMSModules = MSModule;
            }

            if (MedicineModules != null)
            {
                if (MedicineModules.Length > 1)
                {
                    foreach (var item in MedicineModules)
                    {
                        MedModule = item;
                        if (GetMedModules == "")
                        {
                            GetMedModules = MedModule;
                        }
                        else
                        {
                            GetMedModules = GetMedModules + "/" + MedModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in MedicineModules)
                    {
                        MedModule = item;
                    }
                    GetMedModules = MedModule;
                }
            }
            else
            {
                GetMedModules = MedModule;
            }

            if (AccountingModules != null)
            {
                if (AccountingModules.Length > 1)
                {
                    foreach (var item in AccountingModules)
                    {
                        AccModule = item;
                        if (GetAccModules == "")
                        {
                            GetAccModules = AccModule;
                        }
                        else
                        {
                            GetAccModules = GetAccModules + "/" + AccModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in AccountingModules)
                    {
                        AccModule = item;
                    }
                    GetAccModules = AccModule;
                }
            }
            else
            {
                GetAccModules = AccModule;
            }

            if (AnthropologyModules != null)
            {
                if (AnthropologyModules.Length > 1)
                {
                    foreach (var item in AnthropologyModules)
                    {
                        AntModule = item;
                        if (GetAntModules == "")
                        {
                            GetAntModules = AntModule;
                        }
                        else
                        {
                            GetAntModules = GetAntModules + "/" + AntModule;
                        }
                    }
                }
                else
                {
                    foreach (var item in AnthropologyModules)
                    {
                        AntModule = item;
                    }
                    GetAntModules = AntModule;
                }
            }
            else
            {
                GetAntModules = AntModule;
            }

            UserPost UserPosts = new UserPost()
            {
                Name = UserPost.Name,
                Email = UserPost.Email,
                Gender = UserPost.Gender,
                //Courses = UserPost.Courses,
                AboutYourSelf = UserPost.AboutYourSelf,
                CreatedAt = DateTime.Now,
                Courses = GetCourses,
                Computer = GetCSModules,
                Engineering = GetEModules,
                Teaching = GetTModules,
                Biology = GetBioModules,
                Geographys = GetGeoModules,
                Math = GetMaModules,
                Communication = GetComModules,
                Chemistry = GetCheModules,
                Physics = GetPhyModules,
                Law = GetLawModules,
                Economics = GetEcoModules,
                Business = GetBusModules,
                Music = GetMusModules,
                Architecture = GetArchModules,
                English = GetEngModules,
                Dentistry = GetDenModules,
                MarineScience = GetMSModules,
                Medicine = GetMedModules,
                Accounting = GetAccModules,
                Anthropology = GetAntModules,
                IsActive = 1
            };

            if (Picture != null)
            {
                Directory.CreateDirectory(Server.MapPath("~") + "Content/UserPictures/");
                string filenamenoext = System.IO.Path.GetFileNameWithoutExtension(Picture.FileName);
                string ext = System.IO.Path.GetExtension(System.IO.Path.GetFileName(Picture.FileName));
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".JPG" || ext == ".JPEG" || ext == ".PNG")
                {
                    int filesize;
                    filesize = Picture.ContentLength;
                    if (filesize >= 2000000)
                    {
                        return RedirectToAction("Index", "Home", new { errormsg = "Your can Upload Maximum 2MB file" });
                    }
                    else
                    {
                        filenamenoext = "_" + DateTime.Now.ToString("yymmddfff") + "_" + Picture.FileName;
                        string path = Path.Combine(Server.MapPath("~/Content/UserPictures"), filenamenoext);
                        // file is uploaded
                        Picture.SaveAs(path);
                        UserPosts.Picture = "/Content/UserPictures/" + filenamenoext;
                    }
                }
                else
                {
                    ViewBag.wrongFile = "Wrong file format!";
                    return View("Index", UserPost);
                }
            }

            if (new UserPostBL().AddUserPost(UserPosts))
            {
                return RedirectToAction("Index", "Home", new { sucmsg = "Your Data Uploaded Successfully" });
            }
            else
            {
                return RedirectToAction("Index", "Home", new { errormsg = "Your Form did not Submitted Successfully. Please Save it Again" });
            }
        }

        public ActionResult Search(HttpPostedFileBase Picture, string Name = "", string Gender ="", string AboutYourSelf = "", int value = 1)
        {
            ViewBag.Name = Name;
            ViewBag.Gender = Gender;
            ViewBag.AboutYourSelf = AboutYourSelf;
            if (Picture != null)
            {
                Directory.CreateDirectory(Server.MapPath("~") + "Content/UserPictures/");
                string filenamenoext = System.IO.Path.GetFileNameWithoutExtension(Picture.FileName);
                string ext = System.IO.Path.GetExtension(System.IO.Path.GetFileName(Picture.FileName));
                if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".JPG" || ext == ".JPEG" || ext == ".PNG")
                {
                    int filesize;
                    filesize = Picture.ContentLength;
                    if (filesize >= 2000000)
                    {
                        return RedirectToAction("Index", "Home", new { errormsg = "Your can Upload Maximum 2MB file" });
                    }
                    else
                    {
                        filenamenoext = "_" + DateTime.Now.ToString("yymmddfff") + "_" + Picture.FileName;
                        string path = Path.Combine(Server.MapPath("~/Content/UserPictures"), filenamenoext);
                        // file is uploaded
                        Picture.SaveAs(path);
                        ViewBag.Picture = "/Content/UserPictures/" + filenamenoext;
                    }
                }
                else
                {
                    ViewBag.wrongFile = "Wrong file format!";
                    return View("Index", Name);
                }
            }
            return View();
        }

        public ActionResult PostDataOnlyCourses(string Modules, string Done, string GOBack, string Picture = "", string Name = "", string Gender = "", string AboutYourSelf = "", string ComputerScience = "",
            string Engineering = "", string Teaching = "", string Biology = "", string Geography = "",
            string Math = "", string Communication = "", string Chemistry = "", string Physics = "", string Law = "", string Economics = "", string Business = "",
            string Music = "", string Architecture = "", string English = "", string Dentistry = "", string MarineScience = "", string Medicine = "", string Accounting = "",
            string Anthropology = "")
        {
            if (!string.IsNullOrEmpty(Done))
            {
                string getCourses = "";
                List<string> course = new List<string>();

                if (ComputerScience != "" && ComputerScience != null)
                {
                    course.Add(ComputerScience);
                }
                if (Engineering != "" && Engineering != null)
                {
                    course.Add(Engineering);
                }
                if (Teaching != "" && Teaching != null)
                {
                    course.Add(Teaching);
                }
                if (Biology != "" && Biology != null)
                {
                    course.Add(Biology);
                }
                if (Geography != "" && Geography != null)
                {
                    course.Add(Geography);
                }
                if (Math != "" && Math != null)
                {
                    course.Add(Math);
                }
                if (Communication != "" && Communication != null)
                {
                    course.Add(Communication);
                }
                if (Chemistry != "" && Chemistry != null)
                {
                    course.Add(Chemistry);
                }
                if (Physics != "" && Physics != null)
                {
                    course.Add(Physics);
                }
                if (Law != "" && Law != null)
                {
                    course.Add(Law);
                }
                if (Economics != "" && Economics != null)
                {
                    course.Add(Economics);
                }
                if (Business != "" && Business != null)
                {
                    course.Add(Business);
                }

                if (Music != "" && Music != null)
                {
                    course.Add(Music);
                }
                if (Architecture != "" && Architecture != null)
                {
                    course.Add(Architecture);
                }
                if (English != "" && English != null)
                {
                    course.Add(English);
                }
                if (Dentistry != "" && Dentistry != null)
                {
                    course.Add(Dentistry);
                }
                if (MarineScience != "" && MarineScience != null)
                {
                    course.Add(MarineScience);
                }
                if (Medicine != "" && Medicine != null)
                {
                    course.Add(Medicine);
                }
                if (Accounting != "" && Accounting != null)
                {
                    course.Add(Accounting);
                }
                if (Anthropology != "" && Anthropology != null)
                {
                    course.Add(Anthropology);
                }

                foreach (var item in course)
                {
                    if (getCourses == "")
                    {
                        getCourses = item;
                    }
                    else
                    {
                        getCourses = getCourses + "/" + item;
                    }
                }

                UserPost UserPosts = new UserPost()
                {
                    Name = Name,
                    Gender = Gender,
                    AboutYourSelf = AboutYourSelf,
                    CreatedAt = DateTime.Now,
                    Courses = getCourses,
                    Picture = Picture,
                    IsActive = 1
                };

                if (new UserPostBL().AddUserPost(UserPosts))
                {
                    return RedirectToAction("Index", "Home", new { sucmsg = "Your Data Uploaded Successfully" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { errormsg = "Your Form did not Submitted Successfully. Please Save it Again" });
                }

            }

            if (!string.IsNullOrEmpty(Modules))
            {
                return RedirectToAction("Modules", "Home", new {
                    Picture = Picture,
                    Name = Name,
                    Gender = Gender,
                    AboutYourSelf = AboutYourSelf,
                    ComputerScience = ComputerScience, Engineering = Engineering, Teaching = Teaching, Biology = Biology,
                    Geography = Geography, Math = Math,
                    Communication = Communication,
                    Chemistry = Chemistry,
                    Physics = Physics,
                    Law = Law,
                    Economics = Economics,
                    Business = Business,
                    Music = Music,
                    Architecture = Architecture,
                    English = English,
                    Dentistry= Dentistry,
                    MarineScience = MarineScience,
                    Medicine = Medicine,
                    Accounting = Accounting,
                    Anthropology = Anthropology,
                });
            }
            if (!string.IsNullOrEmpty(GOBack))
            {
                return RedirectToAction("Index", "Home", new
                {

                });
            }
            return RedirectToAction("Index", "Home", new { errormsg = "Your Form did not Submitted Successfully. Please Save it Again" });
        }


        public ActionResult Modules(string Picture = "", string Name = "", string Gender = "", string AboutYourSelf = "", string ComputerScience = "", string Engineering = "", string Teaching = "", string Biology = "", string Geography = "", 
            string Math = "", string Communication = "", string Chemistry = "", string Physics = "", string Law = "", string Economics = "", string Business = "",
            string Music = "",string Architecture = "",string English = "",string Dentistry = "",string MarineScience = "",string Medicine = "",string Accounting = "",
            string Anthropology = "")
        {
            ViewBag.Picture = Picture;
            ViewBag.Name = Name;
            ViewBag.Gender = Gender;
            ViewBag.AboutYourSelf = AboutYourSelf;
            ViewBag.ComputerScience = ComputerScience;
            ViewBag.Engineering = Engineering;
            ViewBag.Teaching = Teaching;
            ViewBag.Biology = Biology;
            ViewBag.Geography = Geography;
            ViewBag.Math = Math;
            ViewBag.Communication = Communication;
            ViewBag.Chemistry = Chemistry;
            ViewBag.Physics = Physics;
            ViewBag.Law = Law;
            ViewBag.Economics = Economics;
            ViewBag.Business = Business;
            ViewBag.Music = Music;
            ViewBag.Architecture = Architecture;
            ViewBag.English = English;
            ViewBag.Dentistry = Dentistry;
            ViewBag.MarineScience = MarineScience;
            ViewBag.Medicine = Medicine;
            ViewBag.Accounting = Accounting;
            ViewBag.Anthropology = Anthropology;
            return View();
        }


        public ActionResult PostAddModuleData(string SaveForm, string GoBack, string[] CSoptions, string[] Engineeringoptions, string[] Teachingoptions, string[] Biologyoptions, string[] Geographyoptions,
            string[] Mathoptions, string[] Communicationoptions, string[] Chemistryoptions, string[] Physicsoptions, string[] Lawoptions, string[] Economicsoptions, string[] Businessoptions,
            string[] Musicoptions, string[] Architectureoptions, string[] Englishoptions, string[] Dentistryoptions, string[] MarineScienceoptions, string[] Medicineoptions, string[] Accountingoptions,
            string[] Anthropologyoptions, string Picture = "", string Name = "", string Gender = "", string AboutYourSelf = "", string ComputerScience = "", string Engineering = "", string Teaching = "", string Biology = "", string Geography = "",
            string Math = "", string Communication = "", string Chemistry = "", string Physics = "", string Law = "", string Economics = "", string Business = "",
            string Music = "", string Architecture = "", string English = "", string Dentistry = "", string MarineScience = "", string Medicine = "", string Accounting = "",
            string Anthropology = "")
        {
            if (!string.IsNullOrEmpty(SaveForm))
            {
                string getCourses = "";
                List<string> course = new List<string>();

                if (ComputerScience != "" && ComputerScience != null)
                {
                    course.Add(ComputerScience);
                }
                if (Engineering != "" && Engineering != null)
                {
                    course.Add(Engineering);
                }
                if (Teaching != "" && Teaching != null)
                {
                    course.Add(Teaching);
                }
                if (Biology != "" && Biology != null)
                {
                    course.Add(Biology);
                }
                if (Geography != "" && Geography != null)
                {
                    course.Add(Geography);
                }
                if (Math != "" && Math != null)
                {
                    course.Add(Math);
                }
                if (Communication != "" && Communication != null)
                {
                    course.Add(Communication);
                }
                if (Chemistry != "" && Chemistry != null)
                {
                    course.Add(Chemistry);
                }
                if (Physics != "" && Physics != null)
                {
                    course.Add(Physics);
                }
                if (Law != "" && Law != null)
                {
                    course.Add(Law);
                }
                if (Economics != "" && Economics != null)
                {
                    course.Add(Economics);
                }
                if (Business != "" && Business != null)
                {
                    course.Add(Business);
                }

                if (Music != "" && Music != null)
                {
                    course.Add(Music);
                }
                if (Architecture != "" && Architecture != null)
                {
                    course.Add(Architecture);
                }
                if (English != "" && English != null)
                {
                    course.Add(English);
                }
                if (Dentistry != "" && Dentistry != null)
                {
                    course.Add(Dentistry);
                }
                if (MarineScience != "" && MarineScience != null)
                {
                    course.Add(MarineScience);
                }
                if (Medicine != "" && Medicine != null)
                {
                    course.Add(Medicine);
                }
                if (Accounting != "" && Accounting != null)
                {
                    course.Add(Accounting);
                }
                if (Anthropology != "" && Anthropology != null)
                {
                    course.Add(Anthropology);
                }

                foreach (var item in course)
                {
                    if (getCourses == "")
                    {
                        getCourses = item;
                    }
                    else
                    {
                        getCourses = getCourses + "/" + item;
                    }
                }
                var saveEoptions = "";
                var saveCSoptions = "";
                var saveToptions = "";
                var saveBiooptions = "";
                var saveGeooptions = "";
                var saveMathoptions = "";
                var saveComoptions = "";
                var saveCheoptions = "";
                var savePhyoptions = "";
                var saveLawoptions = "";
                var saveEcooptions = "";
                var saveBusoptions = "";
                var saveMusoptions = "";
                var saveArcoptions = "";
                var saveEngoptions = "";
                var saveDenoptions = "";
                var saveMSoptions = "";
                var saveMedoptions = "";
                var saveAccoptions = "";
                var saveAntoptions = "";

                if(CSoptions != null)
                {
                    if(CSoptions.Length >= 1)
                    {
                        foreach(var item in CSoptions)
                        {
                            if(saveCSoptions == "")
                            {
                                saveCSoptions = item;
                            }
                            else
                            {
                                saveCSoptions = saveCSoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Engineeringoptions != null)
                {
                    if (Engineeringoptions.Length >= 1)
                    {
                        foreach (var item in Engineeringoptions)
                        {
                            if (saveEoptions == "")
                            {
                                saveEoptions = item;
                            }
                            else
                            {
                                saveEoptions = saveEoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Teachingoptions != null)
                {
                    if (Teachingoptions.Length >= 1)
                    {
                        foreach (var item in Teachingoptions)
                        {
                            if (saveToptions == "")
                            {
                                saveToptions = item;
                            }
                            else
                            {
                                saveToptions = saveToptions + "/" + item;
                            }
                        }
                    }
                }

                if (Biologyoptions != null)
                {
                    if (Biologyoptions.Length >= 1)
                    {
                        foreach (var item in Biologyoptions)
                        {
                            if (saveBiooptions == "")
                            {
                                saveBiooptions = item;
                            }
                            else
                            {
                                saveBiooptions = saveBiooptions + "/" + item;
                            }
                        }
                    }
                }

                if (Geographyoptions != null)
                {
                    if (Geographyoptions.Length >= 1)
                    {
                        foreach (var item in Geographyoptions)
                        {
                            if (saveGeooptions == "")
                            {
                                saveGeooptions = item;
                            }
                            else
                            {
                                saveGeooptions = saveGeooptions + "/" + item;
                            }
                        }
                    }
                }

                if (Mathoptions != null)
                {
                    if (Mathoptions.Length >= 1)
                    {
                        foreach (var item in Mathoptions)
                        {
                            if (saveMathoptions == "")
                            {
                                saveMathoptions = item;
                            }
                            else
                            {
                                saveMathoptions = saveMathoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Communicationoptions != null)
                {
                    if (Communicationoptions.Length >= 1)
                    {
                        foreach (var item in Communicationoptions)
                        {
                            if (saveComoptions == "")
                            {
                                saveComoptions = item;
                            }
                            else
                            {
                                saveComoptions = saveComoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Chemistryoptions != null)
                {
                    if (Chemistryoptions.Length >= 1)
                    {
                        foreach (var item in Chemistryoptions)
                        {
                            if (saveCheoptions == "")
                            {
                                saveCheoptions = item;
                            }
                            else
                            {
                                saveCheoptions = saveCheoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Physicsoptions != null)
                {
                    if (Physicsoptions.Length >= 1)
                    {
                        foreach (var item in Physicsoptions)
                        {
                            if (savePhyoptions == "")
                            {
                                savePhyoptions = item;
                            }
                            else
                            {
                                savePhyoptions = savePhyoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Lawoptions != null)
                {
                    if (Lawoptions.Length >= 1)
                    {
                        foreach (var item in Lawoptions)
                        {
                            if (saveLawoptions == "")
                            {
                                saveLawoptions = item;
                            }
                            else
                            {
                                saveLawoptions = saveLawoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Economicsoptions != null)
                {
                    if (Economicsoptions.Length >= 1)
                    {
                        foreach (var item in Economicsoptions)
                        {
                            if (saveEcooptions == "")
                            {
                                saveEcooptions = item;
                            }
                            else
                            {
                                saveEcooptions = saveEcooptions + "/" + item;
                            }
                        }
                    }
                }

                if (Businessoptions != null)
                {
                    if (Businessoptions.Length >= 1)
                    {
                        foreach (var item in Businessoptions)
                        {
                            if (saveBusoptions == "")
                            {
                                saveBusoptions = item;
                            }
                            else
                            {
                                saveBusoptions = saveBusoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Musicoptions != null)
                {
                    if (Musicoptions.Length >= 1)
                    {
                        foreach (var item in Musicoptions)
                        {
                            if (saveMusoptions == "")
                            {
                                saveMusoptions = item;
                            }
                            else
                            {
                                saveMusoptions = saveMusoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Architectureoptions != null)
                {
                    if (Architectureoptions.Length >= 1)
                    {
                        foreach (var item in Architectureoptions)
                        {
                            if (saveArcoptions == "")
                            {
                                saveArcoptions = item;
                            }
                            else
                            {
                                saveArcoptions = saveArcoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Englishoptions != null)
                {
                    if (Englishoptions.Length >= 1)
                    {
                        foreach (var item in Englishoptions)
                        {
                            if (saveEngoptions == "")
                            {
                                saveEngoptions = item;
                            }
                            else
                            {
                                saveEngoptions = saveEngoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Dentistryoptions != null)
                {
                    if (Dentistryoptions.Length >= 1)
                    {
                        foreach (var item in Dentistryoptions)
                        {
                            if (saveDenoptions == "")
                            {
                                saveDenoptions = item;
                            }
                            else
                            {
                                saveDenoptions = saveDenoptions + "/" + item;
                            }
                        }
                    }
                }

                if (MarineScienceoptions != null)
                {
                    if (MarineScienceoptions.Length >= 1)
                    {
                        foreach (var item in MarineScienceoptions)
                        {
                            if (saveMSoptions == "")
                            {
                                saveMSoptions = item;
                            }
                            else
                            {
                                saveMSoptions = saveMSoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Medicineoptions != null)
                {
                    if (Medicineoptions.Length >= 1)
                    {
                        foreach (var item in Medicineoptions)
                        {
                            if (saveMedoptions == "")
                            {
                                saveMedoptions = item;
                            }
                            else
                            {
                                saveMedoptions = saveMedoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Accountingoptions != null)
                {
                    if (Accountingoptions.Length >= 1)
                    {
                        foreach (var item in Accountingoptions)
                        {
                            if (saveAccoptions == "")
                            {
                                saveAccoptions = item;
                            }
                            else
                            {
                                saveAccoptions = saveAccoptions + "/" + item;
                            }
                        }
                    }
                }

                if (Anthropologyoptions != null)
                {
                    if (Anthropologyoptions.Length >= 1)
                    {
                        foreach (var item in Anthropologyoptions)
                        {
                            if (saveAntoptions == "")
                            {
                                saveAntoptions = item;
                            }
                            else
                            {
                                saveAntoptions = saveAntoptions + "/" + item;
                            }
                        }
                    }
                }


                UserPost UserPosts = new UserPost()
                {
                    Name = Name,
                    Gender = Gender,
                    AboutYourSelf = AboutYourSelf,
                    CreatedAt = DateTime.Now,
                    Courses = getCourses,
                    Picture = Picture,
                    Computer = saveCSoptions,
                    Engineering = saveEoptions,
                    Teaching = saveToptions,
                    Biology = saveBiooptions,
                    Geographys = saveGeooptions,
                    Math = saveMathoptions,
                    Communication = saveComoptions,
                    Chemistry = saveCheoptions,
                    Physics = savePhyoptions,
                    Law = saveLawoptions,
                    Economics = saveEcooptions,
                    Business = saveBusoptions,
                    Music = saveMusoptions,
                    Architecture = saveArcoptions,
                    English = saveEngoptions,
                    Dentistry = saveDenoptions,
                    MarineScience = saveMSoptions,
                    Medicine = saveMedoptions,
                    Accounting = saveAccoptions,
                    Anthropology = saveAntoptions,
                    IsActive = 1
                };

                if (new UserPostBL().AddUserPost(UserPosts))
                {
                    return RedirectToAction("Index", "Home", new { sucmsg = "Your Data Uploaded Successfully" });
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { errormsg = "Your Form did not Submitted Successfully. Please Save it Again" });
                }
            }
            else
            {
                return RedirectToAction("Search", "Home", new
                {
                    Picture = Picture,
                    Name = Name,
                    Gender = Gender,
                    AboutYourSelf = AboutYourSelf,
                });
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}