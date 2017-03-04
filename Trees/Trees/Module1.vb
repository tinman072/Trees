Module Module1

    Sub Main()
        Dim t As Tree
        t.initialize(10)
        t.addNode("F")
        t.addNode("A")
        t.addNode("E")
        t.addNode("B")
        t.addNode("C")
        t.addNode("D")
        t.addNode("H")
        t.addNode("I")

        t.inOrderPrint(0)
        Console.WriteLine("")
        t.preOrderPrint(0)
        Console.WriteLine("")
        t.postOrderPrint(0)
        Console.WriteLine("")

        Console.WriteLine(t.treeHeight(0))
        Console.WriteLine(t.searchTree("C", 0))

        Console.WriteLine(t.findMin(0))
        Console.WriteLine(t.findMax(0))

        Console.WriteLine(t.sizeOfTree(0))

        t.mirrorTree(0)

        t.inOrderPrint(0)
        Console.WriteLine("")

    End Sub

End Module
