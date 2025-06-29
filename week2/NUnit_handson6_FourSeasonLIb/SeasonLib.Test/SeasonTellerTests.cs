using SeasonsLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonLib.Test
{
    [TestFixture]
    public class SeasonTellerTests
    {
        private SeasonTeller _seasonTeller;

        [SetUp]
        public void SetUp()
        {
            _seasonTeller = new SeasonTeller();
        }

        // ✅ Test case source method
        public static IEnumerable SeasonTestCases
        {
            get
            {
                yield return new TestCaseData("February").Returns("Spring");
                yield return new TestCaseData("March").Returns("Spring");
                yield return new TestCaseData("April").Returns("Summer");
                yield return new TestCaseData("May").Returns("Summer");
                yield return new TestCaseData("June").Returns("Summer");
                yield return new TestCaseData("July").Returns("Monsoon");
                yield return new TestCaseData("August").Returns("Monsoon");
                yield return new TestCaseData("September").Returns("Monsoon");
                yield return new TestCaseData("October").Returns("Autumn");
                yield return new TestCaseData("November").Returns("Autumn");
                yield return new TestCaseData("December").Returns("Winter");
                yield return new TestCaseData("January").Returns("Winter");
                yield return new TestCaseData("UnknownMonth").Returns("Invalid Season");
                yield return new TestCaseData("").Returns("Invalid Season");
            }
        }

        [Test, TestCaseSource(nameof(SeasonTestCases))]
        public string DisplaySeasonBy_ValidMonthName_ReturnsExpectedSeason(string input)
        {
            return _seasonTeller.DisplaySeasonBy(input);
        }
    }
}
