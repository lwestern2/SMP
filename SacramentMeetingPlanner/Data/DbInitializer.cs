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
                        MemberID=1,
                        MeetingID=1,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=1,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=1,
                        MeetingID=1,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=2,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=6,
                        MeetingID=2,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=1,
                        MeetingID=2,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=5,
                        MeetingID=3,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=2,
                        MeetingID=3,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=3,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=7,
                        MeetingID=4,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=8,
                        MeetingID=4,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=4,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=5,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=5,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=5,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=6,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=4,
                        MeetingID=6,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=6,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=5,
                        MeetingID=7,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=6,
                        MeetingID=7,
                        assignment="Closing Prayer"
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=7,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=7,
                        MeetingID=8,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=8,
                        MeetingID=8,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=8,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=9,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=2,
                        MeetingID=9,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=9,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=3,
                        MeetingID=10,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=4,
                        MeetingID=10,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=10,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=5,
                        MeetingID=11,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=6,
                        MeetingID=11,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=11,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=7,
                        MeetingID=12,
                        assignment="OpeningPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=8,
                        MeetingID=12,
                        assignment="ClosingPrayer",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=1,
                        MeetingID=12,
                        assignment="Conducting",
                        Topic=""
                    },
                    new Assignment
                    {
                        MemberID=5,
                        MeetingID=13,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    },
                    new Assignment
                    {
                            MemberID=2,
                            MeetingID=13,
                            assignment="Speaker",
                            Topic="Scripture Study"
                    },
                    new Assignment{
                            MemberID=1,
                            MeetingID=13,
                            assignment="Conducting",
                            Topic=""
                    },
                    new Assignment{
                        MemberID=1,
                        MeetingID=1,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=1,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=3,
                        MeetingID=2,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=4,
                        MeetingID=2,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=5,
                        MeetingID=3,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=6,
                        MeetingID=3,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=7,
                        MeetingID=4,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    },
                    new Assignment{
                        MemberID=8,
                        MeetingID=4,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    },

                    new Assignment{
                        MemberID=1,
                        MeetingID=5,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=5,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=3,
                        MeetingID=6,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=4,
                        MeetingID=6,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=5,
                        MeetingID=7,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=6,
                        MeetingID=8,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=7,
                        MeetingID=8,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    },
                    new Assignment{
                        MemberID=8,
                        MeetingID=9,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    },
                    new Assignment{
                        MemberID=1,
                        MeetingID=9,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=2,
                        MeetingID=10,
                        assignment="Speaker",
                        Topic="Prayer"
                    },
                    new Assignment{
                        MemberID=3,
                        MeetingID=10,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=4,
                        MeetingID=11,
                        assignment="Speaker",
                        Topic="Faith"
                    },
                    new Assignment{
                        MemberID=5,
                        MeetingID=11,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=6,
                        MeetingID=12,
                        assignment="Speaker",
                        Topic="General Conference"
                    },
                    new Assignment{
                        MemberID=7,
                        MeetingID=12,
                        assignment="Speaker",
                        Topic="Sacrifice"
                    },
                    new Assignment{
                        MemberID=8,
                        MeetingID=13,
                        assignment="Speaker",
                        Topic="Ministering"
                    },
                    new Assignment{
                        MemberID=1,
                        MeetingID=13,
                        assignment="Speaker",
                        Topic="Scripture Study"
                    }
                };
            foreach (Assignment x in Assignment)
            {
                context.Assignments.Add(x);
            }
            context.SaveChanges();

        }
    }
}