Module Module2

    Public Structure Tree

        Public Structure treeNode
            Dim data As String
            Dim left As Integer
            Dim right As Integer
        End Structure

        Const nullptr = -1

        Dim root As Integer
        Dim FLP As Integer

        Dim treelist() As treeNode

        Sub initialize(ByVal size As Integer)
            root = nullptr
            FLP = 0

            ReDim treelist(size - 1)

            For i = 0 To size - 2
                treelist(i).left = i + 1
                treelist(i).right = nullptr
            Next

            treelist(size - 1).left = nullptr
            treelist(size - 1).right = nullptr
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

        Function searchTree(ByVal key As String, ByVal r As Integer)
            If r = nullptr Then
                Return nullptr
            Else
                If treelist(r).data = key Then
                    Return r
                Else
                    If key < treelist(r).data Then
                        Return searchTree(key, treelist(r).left)
                    Else
                        Return searchTree(key, treelist(r).right)
                    End If
                End If
            End If

        End Function

        Sub inOrderPrint(ByVal r As Integer)
            If r = nullptr Then
                Exit Sub
            End If

            inOrderPrint(treelist(r).left)
            Console.Write(treelist(r).data & " ")
            inOrderPrint(treelist(r).right)

        End Sub

        Sub preOrderPrint(ByVal r As Integer)
            If r = nullptr Then
                Exit Sub
            End If

            Console.Write(treelist(r).data & " ")
            inOrderPrint(treelist(r).left)
            inOrderPrint(treelist(r).right)

        End Sub

        Sub postOrderPrint(ByVal r As Integer)
            If r = nullptr Then
                Exit Sub
            End If

            inOrderPrint(treelist(r).left)
            inOrderPrint(treelist(r).right)
            Console.Write(treelist(r).data & " ")

        End Sub

        Function treeHeight(ByVal r As Integer)
            If r = nullptr Then
                Return 0
            Else
                Dim leftHeight As Integer = 0
                Dim rightHeight As Integer = 0

                leftHeight = treeHeight(treelist(r).left)
                rightHeight = treeHeight(treelist(r).right)

                If leftHeight > rightHeight Then
                    Return leftHeight + 1
                Else
                    Return rightHeight + 1
                End If
            End If
        End Function

        Function findMin(ByVal r As Integer)
            If treelist(r).left = nullptr Then
                Return r
            Else
                Return findMin(treelist(r).left)
            End If
        End Function

        Function findMax(ByVal r As Integer)
            If treelist(r).right = nullptr Then
                Return r
            Else
                Return findMax(treelist(r).right)
            End If
        End Function


    End Structure

End Module
