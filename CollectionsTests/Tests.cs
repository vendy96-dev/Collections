using NUnit.Framework;
using Collections;

namespace CollectionsTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyConstructor()
        {
            //Arrange
            var nums = new Collection<int>();
            //Act

            //Assert
            Assert.AreEqual(0, nums.Count);
            Assert.AreEqual(16, nums.Capacity);
            Assert.AreEqual(nums.ToString(), Is.EqualTo("[]"));
        }

        [Test]
        public void Test_ConstructorSingleItem()
        {
            var nums = new Collection<int>(5);
            Assert.That(nums.ToString, Is.EqualTo("[5]"));
        }
        [Test]
        public void Test_AddSingleItem()
        {
            var nums = new Collection<int>();
            nums.Add(5);
            Assert.That(nums.ToString(), Is.EqualTo("[5]"));
        }
    }
}