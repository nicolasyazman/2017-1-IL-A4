using FluentAssertions;
using IntechCode.IntechCollection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace IntechCode.Tests.IntechCollection.Tests
{
    [NUnit.Framework.TestFixture]
    public class MyListTests
    {
        [NUnit.Framework.Test]
        [Fact]
        public void MyList_instantiated_count_is_zero()
        {
            // Arrange
            MyList<int> mylist = new MyList<int>();

            // Act

            // Assert
            mylist.Count.Should().Be(0);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void MyListAddTest()
        {
            // Arrange
            MyList<int> mylist = new MyList<int>();

            // Act
            mylist.Add(3);
            // Assert
            mylist.Count.Should().Be(1);
            mylist[0].Should().Be(3);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void MyListAddBourrin()
        {
            // Arrange
            MyList<int> mylist = new MyList<int>();

            // Act
            for (int i = 0; i < 1283; i++)
            {
                mylist.Add(i);
            }
            // Assert
            mylist.Count.Should().Be(1283);
            for (int i = 0; i < 1283; i++)
                mylist[i].Should().Be(i);
        }

        [NUnit.Framework.Test]
        [Fact]
        public void MyListRemoveElement()
        {
            // Arrange
            MyList<int> mylist = new MyList<int>();

            // Act
            for (int i = 0; i < 10; i++)
            {
                mylist.Add(i);
            }
            mylist.RemoveAt(5);
            // Assert
            mylist.Count.Should().Be(9);
            for (int i = 0; i < 5; i++)
                mylist[i].Should().Be(i);
            for (int i = 5; i < 9; i++)
                mylist[i].Should().Be(i + 1);
        }
    }
}
