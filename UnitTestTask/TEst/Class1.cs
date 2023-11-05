using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestTask;

namespace TEst
{
   [TestFixture]
  public class Class1
  {
      [Test]
      public void TestAllStudents()
      {
          Program program = new Program();
          List<Student> students = program.AllStudents();

          Assert.AreEqual(5, students.Count);
      }


      [Test]
      public void TestGetDetails()
      {
          Program program = new Program();
          List<Student> students = program.getDetails(2);

          Assert.AreEqual(1, students.Count);
          Assert.AreEqual("Mohamed", students[0].name);
      }


      [Test]
      public void TestDeleteUser()
      {
          Program program = new Program();
          string result = program.DeleteUser(1, "Ahmed");

          Assert.AreEqual("Success", result);
      }


      [Test]
      public void TestAddUser()
      {
          Program program = new Program();
          string result = program.AddUser("6", "Sarah", "female", new int[] { 80, 70, 90, 85, 92 });

          Assert.AreEqual("Success", result);
      }


      [Test]
      public void TestGrade()
      {
          Program program = new Program();
          int[] studentDegrees = new int[] { 80, 70, 90, 95, 92};
          string studentGrade = program.grade(studentDegrees);

          Assert.AreEqual("Excellent", studentGrade);
      }
  }
}
