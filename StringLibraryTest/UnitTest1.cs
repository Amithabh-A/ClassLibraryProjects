using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expects to return true
            string[] words = { "Alphabet", "A1234", "ABC", "Αθήνα", "Москва" };
            foreach (string word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsTrue(result, $"string : {word} , expected result : true, obtained result : {result}");
            }
        }

        [TestMethod]
        public void TestNotStartsWithUpper()
        {
            // Tests that we expects to return false
            string[] words = { "abcde", "aLOHMORA", "4thepeople", "_hehehe", " what happened? ", ";", "αυτοκινητοβιομηχανία", ".", "popo" };
            foreach (string word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result, $"string : {word} , expected result : false, obtained result : {result}");
            }
        }

        [TestMethod]
        public void TestWithZeroOrNullValues()
        {
            string?[] words = { String.Empty, null };
            foreach (string? word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result, $"string : {word} , expected result : false, obtained result : {result}");
            }
        }
    }
}