using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;


namespace WebApi
{
    internal class DataAccessLayer
    {
        SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False");
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        SqlDataReader dr = null;
        internal string SaveUser(UserModel user)
        {
            cmd = new SqlCommand("select * from Login where email = '" + user.email + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                con.Close();
                return "false";
            }
            else
            {
                con.Close();
                cmd = new SqlCommand("insert into Login Values('" + user.email + "','" + user.password + "','" + user.username + "'," +
                    "'" + user.mobileNumber + "','"+user.userRole+"') ", con);
                con.Open();
                int rowsaffected = cmd.ExecuteNonQuery();
                con.Close();
                
                if (rowsaffected > 0)
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
        }
         internal bool AuthenticateUser(string email, string password)
        {
            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM Login WHERE email = @Email AND password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
        public List<CourseModel> GetCourses()
        {
            List<CourseModel> courses = new List<CourseModel>();

            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM course";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CourseModel course = new CourseModel
                            {
                                courseId = (int)reader["id"],
                                courseName = reader["coursename"].ToString(),
                                courseDescription = reader["coursedescription"].ToString(),
                                courseDuration = reader["courseduration"].ToString(),
                            };

                            courses.Add(course);
                        }
                    }
                }
            }

            return courses;
        }
        public List<InstituteModel> GetInstitute()
        {
            List<InstituteModel> institutes = new List<InstituteModel>();

            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM institute";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InstituteModel institute = new InstituteModel
                            {
                                instituteId = (int)reader["id"],
                                instituteName = reader["institutename"].ToString(),
                                instituteDescription = reader["institutedescription"].ToString(),
                                instituteAddress = reader["instituteaddress"].ToString(),
                                mobile = reader["mobile"].ToString(),
                                email = reader["email"].ToString(),
                            };

                            institutes.Add(institute);
                        }
                    }
                }
            }

            return institutes;
        }
        public List<StudentModel> GetStudent()
        {
            List<StudentModel> students = new List<StudentModel>();

            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM student";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            StudentModel student = new StudentModel
                            {
                                studentId = (int)reader["id"],
                                studentName = reader["studentname"].ToString(),
                                studentDOB = reader["dob"].ToString(),
                                address = reader["studentaddress"].ToString(),
                                mobile = reader["mobile"].ToString(),
                                age = (int)reader["age"],
                            };

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }
        public List<AdmissionModel> GetAdmission()
        {
            List<AdmissionModel> admissions = new List<AdmissionModel>();

            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM admission";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdmissionModel admission = new AdmissionModel
                            {
                                admissionId = (int)reader["id"],
                                courseName = reader["coursename"].ToString(),
                                date = reader["date"].ToString(),
                            };

                            admissions.Add(admission);
                        }
                    }
                }
            }

            return admissions;
        }
        public List<AdmissionModel> GetStatus()
        {
            List<AdmissionModel> admissions = new List<AdmissionModel>();

            using (SqlConnection con = new SqlConnection("User ID =sa;password=examlyMssql@123;server=localhost;Database=boxingacademy;trusted_connection=false;Persist Security Info =False;Encrypt=False"))
            {
                con.Open();

                string query = "SELECT * FROM admission";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdmissionModel admission = new AdmissionModel
                            {
                                admissionId=(int)reader["id"],
                                status = reader["status"].ToString(),
                            };

                            admissions.Add(admission);
                        }
                    }
                }
            }

            return admissions;
        }

    }
}