using SacramentMeetingPlanner.Models;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentMeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var Members = new Member[]
            {
            new Member{FirstName="Carson",LastName="Alexander",Bishopric=true},
            new Member{FirstName="Meredith",LastName="Alonso",Bishopric=false},
            new Member{FirstName="Arturo",LastName="Anand",Bishopric=true},
            new Member{FirstName="Gytis",LastName="Barzdukas",Bishopric=false},
            new Member{FirstName="Yan",LastName="Li",Bishopric=false},
            new Member{FirstName="Peggy",LastName="Justice",Bishopric=false},
            new Member{FirstName="Laura",LastName="Norman",Bishopric=false},
            new Member{FirstName="Nino",LastName="Olivetto",Bishopric=false}
            };
            foreach (Member s in Members)
            {
                context.Members.Add(s);
            }
            context.SaveChanges();

            var Sacrament = new Sacrament[]
            {
                new Sacrament{MeetingDate=DateTime.Parse("2019-04-07"),MeetingDateString="2019-04-07",OpeningHymn="Sweet Hour of Prayer",IntermediateHymn="Joseph Smith's First Prayer",ClosingHymn="We Thank Thee Oh God For a Prophet"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-04-14"),MeetingDateString="2019-04-14",OpeningHymn="The Spirit of God",IntermediateHymn="Praise to the Man",ClosingHymn="Called to Serve"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-04-21"),MeetingDateString="2019-04-21",OpeningHymn="Put Your Shoulder to the Wheel",IntermediateHymn="Praise to the Man",ClosingHymn="Come, Come, Ye Saints"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-04-28"),MeetingDateString="2019-04-28",OpeningHymn="Oh Saints of Zion",IntermediateHymn="I Believe in Christ",ClosingHymn="I Stand All Amazed"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-05-05"),MeetingDateString="2019-05-05",OpeningHymn="How Firm A Foundation",IntermediateHymn="Lead Kindly Light",ClosingHymn="I Need Thee Every HOur"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-05-12"),MeetingDateString="2019-05-12",OpeningHymn="Israel, Israel, God is Calling",IntermediateHymn="Be Still My SOul",ClosingHymn="How Great THou Art"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-05-19"),MeetingDateString="2019-05-19",OpeningHymn="I Believe in Christ",IntermediateHymn="Joseph Smith's First Prayer",ClosingHymn="I KNow that My Redeemer Lives"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-05-26"),MeetingDateString="2019-05-26",OpeningHymn="Sweet HOur of Prayer",IntermediateHymn="Where Can I Turn For Peace?",ClosingHymn="God Be With You 'Til We meet Again"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-06-02"),MeetingDateString="2019-06-02",OpeningHymn="Let Us All Press On",IntermediateHymn="Abide With Me",ClosingHymn="Love At Home"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-06-09"),MeetingDateString="2019-06-09",OpeningHymn="Tis Sweet to Sing the Matchless Love",IntermediateHymn="A Poor Wayfaring Man of Grief",ClosingHymn="I Stand All Amazed"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-06-16"),MeetingDateString="2019-06-16",OpeningHymn="Love One Another",IntermediateHymn="How Firm a Foundation",ClosingHymn="Choose the Right"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-06-23"),MeetingDateString="2019-06-23",OpeningHymn="Nearer My God To Thee",IntermediateHymn="As Zions Youth in Latter Days",ClosingHymn="Hope of Israel"},
                new Sacrament{MeetingDate=DateTime.Parse("2019-06-30"),MeetingDateString="2019-06-30",OpeningHymn="In Humility, Our Savior",IntermediateHymn="Love At Home",ClosingHymn="I Am a Child of God"},
                };
            foreach (Sacrament e in Sacrament)
            {
                context.Sacrament.Add(e);
            }
            context.SaveChanges();

            var Assignment = new Assignment[]
            {
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-07").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Merideth").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-07").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-07").ID,
                        assignment="Conducting"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Arturgo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-14").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Peggy").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-14").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-14").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Yan").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-21").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Merideth").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-21").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-21").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Laura").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-28").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                            MemberID=Members.Single(m => m.FirstName == "Nino").ID,
                            MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-28").ID,
                            assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-04-28").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-05").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment{
                        MemberID=Members.Single(m => m.FirstName == "Merideth").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-05").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-05").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-12").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Gytis").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-12").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-12").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Yan").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-19").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Peggy").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-19").ID,
                        assignment="Closing Prayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-19").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Laura").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-26").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                    MemberID=Members.Single(m => m.FirstName == "Nino").ID,
                    MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-26").ID,
                    assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-05-26").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-02").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Merideth").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-02").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-02").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Arturo").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-09").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Gytis").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-09").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-09").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Yan").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-16").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Peggy").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-16").ID,
                        assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-16").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Laura").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-23").ID,
                        assignment="OpeningPrayer"
                    },
                    new Assignment
                    {
                    MemberID=Members.Single(m => m.FirstName == "Nino").ID,
                    MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-23").ID,
                    assignment="ClosingPrayer"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-23").ID,
                        assignment="Conducting"
                    },
                    new Assignment
                    {
                        MemberID=Members.Single(m => m.FirstName == "Yan").ID,
                        MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-30").ID,
                        assignment="Scripture Study"
                    },
                    new Assignment
                    {
                            MemberID=Members.Single(m => m.FirstName == "Merideth").ID,
                            MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-30").ID,
                            assignment="Scripture Study"
                    },
                    new Assignment{
                            MemberID=Members.Single(m => m.FirstName == "Carson").ID,
                            MeetingID=Sacrament.Single(s => s.MeetingDateString == "2019-06-30").ID,
                            assignment="Conducting"
                    }
                };
            foreach (Assignment x in Assignment)
            {
                context.Assignments.Add(x);
            }
            context.SaveChanges();

            var Speaker = new Speaker[]
            {
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Carson").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-07").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Merideth").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-07").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Arturo").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-14").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Gytis").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-14").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Yan").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-21").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Peggy").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-21").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Laura").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-28").ID,
                        Topic="Scripture Study"
                    },
                    new Speaker{
                    MemberID = Members.Single(c => c.FirstName == "Nino").ID,
                    MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-04-28").ID,
                    Topic="Scripture Study"
                    },

                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Carson").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-05").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Merideth").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-05").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Arturo").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-12").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Gytis").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-12").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Yan").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-19").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Peggy").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-26").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Laura").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-05-26").ID,
                        Topic="Scripture Study"
                    },
                    new Speaker{
                    MemberID = Members.Single(c => c.FirstName == "Nino").ID,
                    MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-02").ID,
                    Topic="Scripture Study"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Carson").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-02").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Merideth").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-09").ID,
                        Topic="Prayer"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Arturo").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-09").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Gytis").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-16").ID,
                        Topic="Faith"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Yan").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-16").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Peggy").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-23").ID,
                        Topic="General Conference"
                    },
                    new Speaker{
                        MemberID = Members.Single(c => c.FirstName == "Laura").ID,
                        MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-23").ID,
                        Topic="Scripture Study"
                    },
                    new Speaker{
                    MemberID = Members.Single(c => c.FirstName == "Nino").ID,
                    MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-30").ID,
                    Topic="Scripture Study"
                    },
                    new Speaker{
                    MemberID = Members.Single(c => c.FirstName == "Carson").ID,
                    MeetingID = Sacrament.Single(c => c.MeetingDateString == "2019-06-30").ID,
                    Topic="Scripture Study"
                    }
            };
            foreach (Speaker z in Speaker)
            {
                context.Speakers.Add(z);
            }
            context.SaveChanges();
        }
    }
}