using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XMLGUI;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using XMLGUI.Forms;
using System.Xml.XPath;

namespace TestMyXml
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Write_1()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("testWrite1.xml");
            IEnumerable<XElement> expected = from t in doc.Descendants("disc")
                                             select t;
            IEnumerable<XElement> actual = viewer.WriteText(expected);
            /////////////////check
            Assert.AreEqual(expected, actual);



          
            ////////////////////////////
           

        }
        //XMLGUI.Forms.Insert insE = new Insert();
        [TestMethod]
        public void TestMethod1_INsert()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("test2Base.xml");
            XMLGUI.Forms.Insert insE = new Insert();

            IEnumerable<XElement> expected = from t in doc.Descendants("disc") select t;
            insE.InsertEl(doc, "1000", "Eng", "Pyper", "120", "15", "10", "12", "кр", "з");

            var albumGroups = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int expected1 = 0;
            foreach (IGrouping<string, XElement> a in albumGroups) expected1 = a.Count();

            XDocument docs = XDocument.Load("test2New.xml");
            var albumGroups1 = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int actual1 = 0;

            foreach (IGrouping<string, XElement> a in albumGroups1) actual1 = a.Count();

            Assert.AreEqual(expected1, actual1);
        }


        [TestMethod]
        public void TestMethod2_INsert()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("test3Base.xml");
            XMLGUI.Forms.Insert insE = new Insert();

            IEnumerable<XElement> expected = from t in doc.Descendants("disc") select t;
            insE.InsertEl(doc, "1001", "Eng", "Pyper", "120", "15", "10", "12", "кр", "з");

            var albumGroups = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int expected1 = 0;
            foreach (IGrouping<string, XElement> a in albumGroups) expected1 = a.Count();

            XDocument docs = XDocument.Load("test3New.xml");
            var albumGroups1 = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int actual1 = 0;

            foreach (IGrouping<string, XElement> a in albumGroups1) actual1 = a.Count();

            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void TestMethod_Write_2()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("testWrite2.xml");
            IEnumerable<XElement> expected = from t in doc.Descendants("disc")
                                             select t;
            IEnumerable<XElement> actual = viewer.WriteText(expected);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod_Write_3()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("testWrite3.xml");
            IEnumerable<XElement> expected = from t in doc.Descendants("disc")
                                             select t;
            IEnumerable<XElement> actual = viewer.WriteText(expected);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod_Write_4()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("testWrite4.xml");
            IEnumerable<XElement> expected = from t in doc.Descendants("disc")
                                             select t;
            IEnumerable<XElement> actual = viewer.WriteText(expected);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_Write_5()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("testWrite5.xml");
            IEnumerable<XElement> expected = from t in doc.Descendants("disc")
                                             select t;
            IEnumerable<XElement> actual = viewer.WriteText(expected);

            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void TestMethod_Write_6()
        //{
        //    XMLGUI.XMLViewer viewer = new XMLViewer();

        //    XDocument doc = XDocument.Load("testWrite6.xml");
        //    IEnumerable<XElement> expected = from t in doc.Descendants("disc")
        //                                     select t;
        //    IEnumerable<XElement> actual = viewer.WriteText(expected);

        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void TestMethod3_INsert()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("test4Base.xml");
            XMLGUI.Forms.Insert insE = new Insert();

            IEnumerable<XElement> expected = from t in doc.Descendants("disc") select t;
            insE.InsertEl(doc, "1003", "Eng", "Pyper", "120", "15", "10", "12", "кр", "з");

            var albumGroups = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int expected1 = 0;
            foreach (IGrouping<string, XElement> a in albumGroups) expected1 = a.Count();

            XDocument docs = XDocument.Load("test4New.xml");
            var albumGroups1 = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int actual1 = 0;

            foreach (IGrouping<string, XElement> a in albumGroups1) actual1 = a.Count();

            Assert.AreEqual(expected1, actual1);
        }

        [TestMethod]
        public void TestMethod4_INsert()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc = XDocument.Load("test4Base.xml");
            XMLGUI.Forms.Insert insE = new Insert();

            IEnumerable<XElement> expected = from t in doc.Descendants("disc") select t;
            insE.InsertEl(doc, "1005", "English", "Pyper", "120", "15", "10", "12", "кр", "з");

            var albumGroups = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int expected1 = 0;
            foreach (IGrouping<string, XElement> a in albumGroups) expected1 = a.Count();

            XDocument docs = XDocument.Load("test4New.xml");
            var albumGroups1 = doc.Root.Elements("disc").GroupBy(t => t.Attribute("disc_id").Value);
            int actual1 = 0;

            foreach (IGrouping<string, XElement> a in albumGroups1) actual1 = a.Count();

            Assert.AreEqual(expected1, actual1);
        }

        //[TestMethod]
        //public void TestNoDistrict()
        //{
        //    XMLGUI.XMLViewer viewer = new XMLViewer();
        //    XDocument doc = XDocument.Load("testNo.xml");

        //    IEnumerable<XElement> expect = from t in doc.Descendants("disc")
        //                                    select t;
        //    string expected = "";
        //    IEnumerable<XElement> actual = viewer.WriteText(expect);
        //    Assert.AreEqual(actual, expected);
        //}


        //[TestMethod]
        //public void TestMethod1_Filter_surname()
        //{
        //    XMLGUI.XMLViewer viewer = new XMLViewer();

        //    XDocument doc = XDocument.Load("testFilter1.xml");
        //    IEnumerable<XElement> tracks = from t in doc.Descendants("disc")
        //                                   select t;
        //    IEnumerable<XElement> expected = from t in tracks
        //                                     where( t.Attribute("surname").Value=="Brown")
        //                                     select t;

        //    //IEnumerable<XElement> actual = viewer.Filter(tracks, "[@surname='Brown']");
        //    IEnumerable<XElement> actual = doc.XPathSelectElements(".//disc[@surname='Brown']");
        //    Assert.ReferenceEquals(actual, expected);

        //}


        [TestMethod]
        public void TestMethod2_Filter_coursework()
        {
            XMLGUI.XMLViewer viewer = new XMLViewer();

            XDocument doc1 = XDocument.Load("base.xml");
            XDocument doc = XDocument.Load("testFilter2.xml");
            IEnumerable<XElement> tracks = from t in doc1.Descendants("disc")
                                           select t;
            //IEnumerable<XElement> expected = from t in tracks
            //                                 where (t.Attribute("coursework").Value == "-")
            //                                 select t;

            IEnumerable<XElement> expected = from t in tracks
                                             where (t.Attribute("coursework").Value == "-")
                                             select t;

            //IEnumerable<XElement> actual = viewer.Filter(tracks, "[@surname='Brown']");
            IEnumerable<XElement> actual = doc.XPathSelectElements(".//disc[@coursework='-']");
            Assert.ReferenceEquals(actual, expected);

        }
        //        XDocument po = XDocument.Load("PurchaseOrders.xml");

        //        // LINQ to XML query  
        //        IEnumerable<XElement> list1 =
        //            from el in po.Descendants("Address")
        //            where (string)el.Attribute("Type") == "Shipping"
        //            select el;

        //        // XPath expression  
        //        IEnumerable<XElement> list2 = po.XPathSelectElements(".//Address[@Type='Shipping']");  

        //if (list1.Count() == list2.Count() &&  
        //        list1.Intersect(list2).Count() == list1.Count())  
        //    Console.WriteLine("Results are identical");  
        //else  
        //    Console.WriteLine("Results differ");  
        //foreach (XElement el in list1)  
        //    Console.WriteLine(el);


    }
}
