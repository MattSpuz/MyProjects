using System;
using Xunit;
using Inventory_Management_Systems;

namespace Inventory_management_Testing
{
    public class UnitTest1
    {
        //add category to tree
        [Fact]
        public void AddCategoryTest()
        {
            //ARRANGE
            InventoryTree testingTree = new InventoryTree();
            bool categoryExists;
            //ACT
            testingTree.CreateCategory("bam");
            categoryExists = testingTree.CategoryExists("bam");
            //ASSERT
            Assert.True(categoryExists);
        }
        //remove category from tree
        [Fact]
        public void RemoveCategoryTest()
        {
            //ARRANGE
            InventoryTree testingTree = new InventoryTree();
            bool categoryExists;
            //ACT
            testingTree.CreateCategory("bam");
            testingTree.RemoveCategory("bam");
            categoryExists = testingTree.CategoryExists("bam");
            //ASSERT
            Assert.False(categoryExists);
        }
        //add shelf stack
        [Fact]
        public void AddShelfTest()
        {
            //ARRANGE
            stack testingStack = new stack();
            int stackSize;
            //ACT
            testingStack.AddShelf(25);
            stackSize = testingStack.size();
            //ASSERT
            Assert.Equal(1, stackSize);

        }
        //remove shelf stack
        [Fact]
        public void RemoveShelfTest()
        {
            //ARRANGE
            stack testingStack = new stack();
            int stackSize;
            //ACT
            testingStack.AddShelf(14);
            testingStack.RemoveShelf(0);
            stackSize = testingStack.size();
            //ASSERT
            Assert.Equal(0, stackSize);

        }
        //check if shelf stack is full
        [Fact]
        public void StackFullTest()
        {
            //ARRANGE
            stack testingStack = new stack();
            testingStack.AddShelf(4);
            bool isFull;
            //ACT
            testingStack.push(0, "nail", 4);
            isFull = testingStack.isFull(0);
            //ASSERT
            Assert.True(isFull);

        }
        [Fact]
        public void StackEmptyTest()
        {
            //ARRANGE
            stack testingStack = new stack();
            testingStack.AddShelf(5);
            int empty;
            //ACT
            testingStack.push(0, "nail", 2);
            testingStack.pop(0);
            testingStack.pop(0);
            empty = testingStack.size(0);
            //ASSERT
            Assert.Equal(-1, empty);
        }
        //check if tree is empty using isEmpty()
        [Fact]
        public void TreeEmptyTest()
        {
            //ARRANGE
            InventoryTree testingTree = new InventoryTree();
            bool isEmpty;
            //ACT
            isEmpty = testingTree.isEmpty();

            //ASSERT
            Assert.True(isEmpty);
        }
        //add an item to tree
        [Fact]
        public void AddItemTest()
        {
            //ARRANGE
            InventoryTree testingTree = new InventoryTree();
            testingTree.CreateCategory("health");
            string product;
            //ACT
            testingTree.Insert("medicine", "health", 1);
            product = testingTree.Search("medicine");
            //ASSERT
            Assert.Equal("medicine", product);
        }
        //remove an item from tree
        [Fact]
        public void RemoveItemTest()
        {
            //ARRANGE
            InventoryTree testingTree = new InventoryTree();
            testingTree.CreateCategory("health");
            string product;
            //ACT
            testingTree.Insert("medicine", "health", 1);
            testingTree.RemoveProduct("medicine", "health");
            product = testingTree.Search("medicine");
            //ASSERT
            Assert.Equal("(items do not exist)", product);
        }
    }
}
