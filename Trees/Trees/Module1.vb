Module Module1
    Public Structure treeNode
        Dim data As String
        Dim left As Integer
        Dim right As Integer
    End Structure

    Public Structure Tree
        Const nullptr = -1

        Dim root As Integer
        Dim FLP As Integer

        Dim treelist() As treeNode

        Sub initialize()
            root = nullptr
            FLP = 0

            ReDim treelist(9)

            For i = 0 To 8
                treelist(i).left = i + 1
                treelist(i).right = nullptr
            Next

            treelist(9).left = nullptr
            treelist(9).right = nullptr
        End Sub

        Sub addNode(ByVal dataItem As String)
            If FLP = nullptr Then
                Console.WriteLine("There is no more space in the tree")
                Exit Sub
            End If

            Dim newNodePointer As Integer = FLP
            treelist(newNodePointer).data = dataItem
            FLP = treelist(newNodePointer).left

            treelist(newNodePointer).left = nullptr
            treelist(newNodePointer).right = nullptr

            If root = nullptr Then
                root = newNodePointer
                Exit Sub
            End If

            Dim TNP As Integer = root
            Dim PNP As Integer = nullptr
            Dim turnedLeft As Boolean = False

            While TNP <> nullptr
                PNP = TNP
                If dataItem < treelist(TNP).data Then
                    turnedLeft = True
                    TNP = treelist(TNP).left
                Else
                    turnedLeft = False
                    TNP = treelist(TNP).right
                End If
            End While


            If turnedLeft = True Then
                treelist(PNP).left = newNodePointer
            Else
                treelist(PNP).right = newNodePointer
            End If



        End Sub

        Sub printTree(ByRef r As Integer)
            If treelist(r).left = nullptr And treelist(r).right = nullptr Then
                Exit Sub
            End If

            printTree(treelist(r).left)
            Console.Write(treelist(r).data)
            printTree(treelist(r).right)

        End Sub


    End Structure

    Sub Main()
        Dim t As Tree
        t.initialize()
        t.addNode("F")
        t.addNode("A")
        t.addNode("E")
        t.addNode("B")
        t.addNode("C")
        t.addNode("D")
        t.addNode("H")
        t.addNode("I")

        t.printTree(0)

    End Sub

End Module
