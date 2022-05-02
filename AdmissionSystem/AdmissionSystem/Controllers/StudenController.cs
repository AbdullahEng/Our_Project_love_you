﻿using AdmissionSystem.Model;
using AdmissionSystem.Model.Repository;
using AdmissionSystem.View_Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionSystem.Controllers
{
    public class StudenController : Controller
    {
        private readonly CRUD_Operation_Interface<Student> studentRepository;
        private readonly IHostingEnvironment hosting_;
        private readonly CRUD_Operation_Interface<Type_of_high_school_Cirtificate> type_Of_High_School_Cirtificate_Repository;
        private readonly CRUD_Operation_Interface<Department_relation_Type> department_Relation_Type_Repository;
        private readonly CRUD_Operation_Interface<Statues_Of_Student> statues_Of_Student_Repository;
        private readonly CRUD_Operation_Interface<Tracking_Rate> tracking_Rate_Repository;
        private readonly CRUD_Operation_Interface<Admission_Eligibilty_Certificate> admission_Eligibilty_Certificate_Repository;

        public StudenController(CRUD_Operation_Interface<Student> StudentRepository,
            IHostingEnvironment hosting_,
            CRUD_Operation_Interface<Type_of_high_school_Cirtificate> Type_of_high_school_Cirtificate_Repository,
            CRUD_Operation_Interface<Department_relation_Type> Department_relation_Type_Repository,
            CRUD_Operation_Interface<Statues_Of_Student> Statues_Of_Student_Repository,
             CRUD_Operation_Interface<Tracking_Rate> Tracking_Rate_Repository,
             CRUD_Operation_Interface<Admission_Eligibilty_Certificate> Admission_Eligibilty_Certificate_Repository
            )
        {
            studentRepository = StudentRepository;
            this.hosting_ = hosting_;
            type_Of_High_School_Cirtificate_Repository = Type_of_high_school_Cirtificate_Repository;
            department_Relation_Type_Repository = Department_relation_Type_Repository;
            statues_Of_Student_Repository = Statues_Of_Student_Repository;
            tracking_Rate_Repository = Tracking_Rate_Repository;
            admission_Eligibilty_Certificate_Repository = Admission_Eligibilty_Certificate_Repository;
        }
        // GET: StudenController
        public ActionResult Index()
        {
            var allstudents = studentRepository.List();
                        return View(allstudents);
        }

        
        // GET: StudenController/Details/5
        public ActionResult Details(int id)
        {

            var student = studentRepository.Find(id);
            var certeficat = admission_Eligibilty_Certificate_Repository.Find(student.Admission_Eligibilty_Requist_For_UNsy_Certificate.id);

            var collection = new Student_View_Model
            {
                Birth = student.Birth,
                Civil_Registriation_City = student.Civil_Registriation_City,
                Email = student.Email,
                Current_Address = student.Current_Address,
                Father_Name_AR = student.Father_Name_AR,
                Father_Name_EN = student.Father_Name_EN,
                First_Name_AR = student.First_Name_AR,
                Nick_Name = student.Nick_Name,
                Marital_status = student.Marital_status,
                high_school_certificate = student.high_school_certificate,
                Home_s_Phone = student.Home_s_Phone,
                Passport_No = student.Passport_No,
                Mobile_Phone = student.Mobile_Phone,
                First_Name_EN = student.First_Name_EN,
                gender = student.gender,
                Full_Address = student.Full_Address,
                Grandfather_Name_AR = student.Grandfather_Name_AR,
                Grandfather_Name_EN = student.Grandfather_Name_EN,
                Civil_Registrition_No = student.Civil_Registrition_No,
                Nationality = student.Nationality,
                Mother_Name_AR = student.Mother_Name_AR,
                Mother_Name_EN = student.Mother_Name_EN,
                Identity_No = student.Identity_No,
                Identity_back_image_URL = student.Identity_back_image,
                Identity_front_image_URL = student.Identity_front_image,

                LAnguge_of_the_addmintion = certeficat.LAnguge_of_the_addmintion,
                Check_recipt_image_URL = certeficat.check_recipt_image_URL,
                date_of_high_school_cirtificate = certeficat.date_of_high_school_cirtificate,
                Subscription_number = certeficat.Subscription_number,
                The_Rate = student.Admission_Eligibilty_Requist_For_UNsy_Certificate.The_Rate,
                city_of_high_school_cirtificate = certeficat.city_of_high_school_cirtificate,
                course_number = certeficat.course_number,
                Type_Of_Certificat = certeficat.FK_Type_of_high_school_Cirtificate.id,
                Type_Of_certificate_list = FillSelection2(),
                wish_Department_Id1 = certeficat.wish1.id,
                wish_Department_Id2 = certeficat.wish2.id,
                wish_Department_Id3 = certeficat.wish3.id,
                Image_of_crtificat_URL = certeficat.Image_of_crtificat_URL,


            };

            return View(collection);

          
        }

        // GET: StudenController/Create
        public ActionResult Create()
        {
            var Student_With_Certificate = new Student_View_Model { 
                specializtions= FillSelection(),
                Type_Of_certificate_list = FillSelection2()
            };
            return View(Student_With_Certificate);
        }

        // POST: StudenController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student_View_Model collection)
        {
            try
         
            {
                if (ModelState.IsValid)
                {
                    string filenameIMa = string.Empty;
                    if (collection.Image_Of_Crtificat != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameIMa = collection.Identity_No.ToString() + collection.Image_Of_Crtificat.FileName;
                        string fullpath = Path.Combine(uploads, filenameIMa);
                        collection.Image_Of_Crtificat.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }
                    string filenameFront = string.Empty;
                    if (collection.Identity_front_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameFront = collection.Identity_No.ToString() + collection.Identity_front_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameFront);
                        collection.Identity_front_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }
                    string filenameBack = string.Empty;
                    if (collection.Identity_back_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameBack = collection.Identity_No.ToString() + collection.Identity_back_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameBack);
                        collection.Identity_back_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }

                    string filenameCheck = string.Empty;
                    if (collection.check_recipt_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameCheck = collection.Identity_No.ToString() + collection.check_recipt_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameCheck);
                        collection.check_recipt_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }


                    var certificate = new Admission_Eligibilty_Certificate
                    {
                        course_number = collection.course_number,
                        city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                        Image_of_crtificat_URL = filenameIMa,
                        check_recipt_image_URL = filenameCheck,
                        The_Rate = collection.The_Rate,
                        LAnguge_of_the_addmintion = collection.LAnguge_of_the_addmintion,
                        Subscription_number = collection.Subscription_number,
                        date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                        FK_Type_of_high_school_Cirtificate = type_Of_High_School_Cirtificate_Repository.Find(collection.Type_Of_Certificat),
                        wish1 = department_Relation_Type_Repository.Find(collection.wish_Department_Id1),
                        wish2 = department_Relation_Type_Repository.Find(collection.wish_Department_Id2),
                        wish3 = department_Relation_Type_Repository.Find(collection.wish_Department_Id2)
                    };

                    var student = new Student
                    {
                        Nick_Name = collection.Nick_Name,
                        Birth = collection.Birth,
                        Civil_Registriation_City = collection.Civil_Registriation_City,
                        Email = collection.Email,
                        Current_Address = collection.Current_Address,
                        Father_Name_AR = collection.Father_Name_AR,
                        First_Name_AR = collection.First_Name_AR,
                        Father_Name_EN = collection.Father_Name_EN,
                        First_Name_EN = collection.First_Name_EN,
                        Full_Address = collection.Full_Address,
                        gender = collection.gender,
                        Grandfather_Name_AR = collection.Grandfather_Name_AR,
                        Grandfather_Name_EN = collection.Grandfather_Name_EN,
                        high_school_certificate = collection.high_school_certificate,
                        Identity_back_image = filenameBack,
                        Nationality = collection.Nationality,
                        Mobile_Phone = collection.Mobile_Phone,
                        Home_s_Phone = collection.Home_s_Phone,
                        Passport_No = collection.Passport_No,
                        Identity_front_image = filenameFront,
                        Mother_Name_AR = collection.Mother_Name_AR,
                        Identity_No = collection.Identity_No,
                        Marital_status = collection.Marital_status,
                        Mother_Name_EN = collection.Mother_Name_EN,
                        Civil_Registrition_No = collection.Civil_Registrition_No,
                        Admission_Eligibilty_Requist_For_UNsy_Certificate = certificate

                    };

                    studentRepository.Add(student);

                    var Tracking = new Tracking_Rate
                    {
                        FK_Student_Info = student,
                        old_rate = collection.The_Rate,

                    };
                    tracking_Rate_Repository.Add(Tracking);
                    var status_of_student = new Statues_Of_Student
                    {
                        Checked_city_certificate = false,
                        Checked_Identity = false,
                        Checked_Rate = false,
                        Checked_recipet = false,
                        FK_Student_Info = student,
                        
                    };
                    statues_Of_Student_Repository.Add(status_of_student);
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
                return View();
            }
        }

        // GET: StudenController/Edit/5
        public ActionResult Edit(int id)
        {
            var student = studentRepository.Find(id);
            var certeficat = admission_Eligibilty_Certificate_Repository.Find(student.Admission_Eligibilty_Requist_For_UNsy_Certificate.id);

            var collection = new Student_View_Model
            {
                Birth = student.Birth,
                Civil_Registriation_City = student.Civil_Registriation_City,
                Email = student.Email,
                Current_Address = student.Current_Address,
                Father_Name_AR = student.Father_Name_AR,
                Father_Name_EN = student.Father_Name_EN,
                First_Name_AR = student.First_Name_AR,
                Nick_Name = student.Nick_Name,
                Marital_status = student.Marital_status,
                high_school_certificate = student.high_school_certificate,
                Home_s_Phone = student.Home_s_Phone,
                Passport_No = student.Passport_No,
                Mobile_Phone = student.Mobile_Phone,
                First_Name_EN = student.First_Name_EN,
                gender = student.gender,
                Full_Address = student.Full_Address,
                Grandfather_Name_AR = student.Grandfather_Name_AR,
                Grandfather_Name_EN = student.Grandfather_Name_EN,
                Civil_Registrition_No = student.Civil_Registrition_No,
                Nationality = student.Nationality,
                Mother_Name_AR = student.Mother_Name_AR,
                Mother_Name_EN = student.Mother_Name_EN,
                Identity_No = student.Identity_No,
                Identity_back_image_URL = student.Identity_back_image,
                Identity_front_image_URL = student.Identity_front_image,

                LAnguge_of_the_addmintion = certeficat.LAnguge_of_the_addmintion,
                Check_recipt_image_URL = certeficat.check_recipt_image_URL,
                date_of_high_school_cirtificate = certeficat.date_of_high_school_cirtificate,
                Subscription_number = certeficat.Subscription_number,
                The_Rate = student.Admission_Eligibilty_Requist_For_UNsy_Certificate.The_Rate,
                city_of_high_school_cirtificate = certeficat.city_of_high_school_cirtificate,
                course_number = certeficat.course_number,
                Type_Of_Certificat = certeficat.FK_Type_of_high_school_Cirtificate.id,
                Type_Of_certificate_list = FillSelection2(),
                wish_Department_Id1 = certeficat.wish1.id,
                wish_Department_Id2 = certeficat.wish2.id,
                wish_Department_Id3 = certeficat.wish3.id,
                Image_of_crtificat_URL = certeficat.Image_of_crtificat_URL,


            };

            return View(collection);
        }

        // POST: StudenController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student_View_Model collection)
        {
            try
            {


                string filenameIMa = string.Empty;
                string filenameFront = string.Empty;
                string filenameBack = string.Empty;
                string filenameCheck = string.Empty;

                if (collection.Check_recipt_image_URL!=null  || collection.Identity_front_image_URL!=null || collection.Identity_back_image_URL!=null ||  collection.Image_of_crtificat_URL !=null)
                {
                    if (collection.Image_Of_Crtificat != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameIMa = collection.Identity_No.ToString() + collection.Image_Of_Crtificat.FileName;
                        string fullpath = Path.Combine(uploads, filenameIMa);
                        //delete Old File

                        string oldFileName = collection.Image_of_crtificat_URL;
                        string fullOldPath = Path.Combine(uploads, oldFileName);
                        if (fullpath != fullOldPath)
                        {
                            System.IO.File.Delete(fullOldPath);
                            //save new image
                            collection.Image_of_crtificat_URL = filenameIMa;
                            collection.Image_Of_Crtificat.CopyTo(new FileStream(fullpath, FileMode.Create));
                        }
                    }

                    if (collection.Identity_front_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameFront = collection.Identity_No.ToString() + collection.Identity_front_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameFront);

                        string oldFileName = collection.Identity_front_image_URL;
                        string fullOldPath = Path.Combine(uploads, oldFileName);
                        if (fullpath != fullOldPath)
                        {
                            System.IO.File.Delete(fullOldPath);
                            //save new image
                            collection.Identity_front_image_URL = filenameFront;
                            collection.Identity_front_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                        }




                    }

                    if (collection.Identity_back_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameBack = collection.Identity_No.ToString() + collection.Identity_back_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameBack);

                        string oldFileName = collection.Identity_back_image_URL;
                        string fullOldPath = Path.Combine(uploads, oldFileName);
                        if (fullpath != fullOldPath)
                        {
                            System.IO.File.Delete(fullOldPath);
                            //save new image
                            collection.Identity_back_image_URL = filenameBack;
                            collection.Identity_back_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                        }


                    }
                    if (collection.check_recipt_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameCheck = collection.Identity_No.ToString() + collection.check_recipt_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameCheck);

                        string oldFileName = collection.Check_recipt_image_URL;
                        string fullOldPath = Path.Combine(uploads, oldFileName);
                        if (fullpath != fullOldPath)
                        {
                            System.IO.File.Delete(fullOldPath);
                            collection.Check_recipt_image_URL = filenameCheck;
                            //save new image
                            collection.check_recipt_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                        }

                    }
                }
                else {
                    if (collection.Image_Of_Crtificat != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameIMa = collection.Identity_No.ToString() + collection.Image_Of_Crtificat.FileName;
                        string fullpath = Path.Combine(uploads, filenameIMa);
                        collection.Image_of_crtificat_URL = filenameIMa;

                        collection.Image_Of_Crtificat.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }
                    
                    if (collection.Identity_front_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameFront = collection.Identity_No.ToString() + collection.Identity_front_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameFront);
                        collection.Identity_front_image_URL = filenameFront;

                        collection.Identity_front_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }
                    
                    if (collection.Identity_back_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameBack = collection.Identity_No.ToString() + collection.Identity_back_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameBack);
                        collection.Identity_back_image_URL = filenameBack;
                        collection.Identity_back_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }

                    
                    if (collection.check_recipt_image != null)
                    {
                        string uploads = Path.Combine(hosting_.WebRootPath, "Uploads");
                        filenameCheck = collection.Identity_No.ToString() + collection.check_recipt_image.FileName;
                        string fullpath = Path.Combine(uploads, filenameCheck);
                        collection.Check_recipt_image_URL = filenameCheck;
                        collection.check_recipt_image.CopyTo(new FileStream(fullpath, FileMode.Create));
                    }

                }

                var certificate_ = new Admission_Eligibilty_Certificate
                {
                    id = id,
                    FK_student_InfoId = id,
                    check_recipt_image_URL = collection.Check_recipt_image_URL,
                    city_of_high_school_cirtificate = collection.city_of_high_school_cirtificate,
                    course_number = collection.course_number,
                    date_of_high_school_cirtificate = collection.date_of_high_school_cirtificate,
                    Image_of_crtificat_URL = collection.Image_of_crtificat_URL,
                    LAnguge_of_the_addmintion = collection.LAnguge_of_the_addmintion,
                    Subscription_number = collection.Subscription_number,
                    The_Rate = collection.The_Rate,
                    wish1 = department_Relation_Type_Repository.Find(collection.wish_Department_Id1),
                    wish2 = department_Relation_Type_Repository.Find(collection.wish_Department_Id2),
                    wish3 = department_Relation_Type_Repository.Find(collection.wish_Department_Id3),
                    FK_Type_of_high_school_Cirtificate = type_Of_High_School_Cirtificate_Repository.Find(collection.Type_Of_Certificat)

                };

                var student = new Student
                {

                    Id = id,
                    Birth = collection.Birth,
                    Civil_Registriation_City = collection.Civil_Registriation_City,
                    Civil_Registrition_No = collection.Civil_Registrition_No,
                    Current_Address = collection.Current_Address,
                    Email = collection.Email,
                    Father_Name_AR = collection.Father_Name_AR,
                    Father_Name_EN = collection.Father_Name_EN,
                    Grandfather_Name_AR = collection.Grandfather_Name_AR,
                    Grandfather_Name_EN = collection.Grandfather_Name_EN,
                    Identity_back_image = collection.Identity_back_image_URL,
                    Identity_front_image = collection.Identity_front_image_URL,
                    First_Name_AR = collection.First_Name_AR,
                    First_Name_EN = collection.First_Name_EN,
                    Full_Address = collection.Full_Address,
                    gender = collection.gender,
                    high_school_certificate = collection.high_school_certificate,
                    Home_s_Phone = collection.Home_s_Phone,
                    Identity_No = collection.Identity_No,
                    Marital_status = collection.Marital_status,
                    Mobile_Phone = collection.Mobile_Phone,
                    Mother_Name_AR = collection.Mother_Name_AR,
                    Mother_Name_EN = collection.Mother_Name_EN,
                    Nationality = collection.Nationality,
                    Nick_Name = collection.Nick_Name,
                    Passport_No = collection.Passport_No,
                  

                };

                admission_Eligibilty_Certificate_Repository.Update(id, certificate_);
                studentRepository.Update(id, student); 

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                return View(e);
            }
        }

        // GET: StudenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudenController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        List<Department_relation_Type> FillSelection()
        {
            var types = department_Relation_Type_Repository.List().ToList();
           // types.Insert(0, new Department_relation_Type { id = -1, = "-------pleas select auther-------" });
            return (types);

        }

        List<Type_of_high_school_Cirtificate> FillSelection2()
        {
            var types = type_Of_High_School_Cirtificate_Repository.List().ToList();
            // types.Insert(0, new Department_relation_Type { id = -1, = "-------pleas select auther-------" });
            return (types);

        }

    }
}
