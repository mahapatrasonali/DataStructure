namespace BinarySearchTreeDemo
{
    class Program
    {
       public static void Main(string[] args) 
        {
           BinaryTree binaryTree= new BinaryTree();
            binaryTree.Add(20);
            binaryTree.Add(13);
            binaryTree.Add(9);
            binaryTree.Add(25);
            binaryTree.Add(30);
            binaryTree.Add(22);
            binaryTree.TransversePreOrder(binaryTree.Root);



        }


    }
}
