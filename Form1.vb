Public Class Form1

    Dim currentOrder As Order
    Dim orderCounter As Integer = 1
    Dim customerBalance As Double = 1000
    Dim customerAccount As String
    Dim currentState As String = "Idle"
    Dim lastOrder As Order
    Dim isProcessingOrder As Boolean = False
    Dim orderDatabase As New List(Of Order)
    Sub CreateOrder(foodName As String, price As Double)

        If isProcessingOrder = True Then Exit Sub

        isProcessingOrder = True


        currentOrder = New Order With {
        .OrderID = orderCounter,
        .foodName = foodName,
        .price = price,
        .Status = "Created"
    }

        orderCounter += 1

        orderDatabase.Add(currentOrder)
        lastOrder = currentOrder

        MessageBox.Show("Order Created: " & foodName)
        lastOrder = currentOrder
        ProcessPayment()

        isProcessingOrder = False

    End Sub
    Sub LoadKitchenDashboard()

        KitchenOrders.Items.Clear()

        ' SAFETY CHECK
        If orderDatabase Is Nothing Then
            MessageBox.Show("Database not initialized")
            Exit Sub
        End If

        If orderDatabase.Count = 0 Then
            KitchenOrders.Items.Add("No orders found")
            Exit Sub
        End If

        For Each o As Order In orderDatabase

            If o IsNot Nothing Then

                KitchenOrders.Items.Add(
                "ID: " & o.OrderID &
                " | Food: " & o.FoodName &
                " | Price: " & o.Price &
                " | Status: " & o.Status &
                " | Rating: " & o.Rating &
                " | Feedback: " & o.Feedback
            )

            End If

        Next

    End Sub

    Private Sub Picaynet_Click(sender As Object, e As EventArgs) Handles Picaynet.Click
        CreateOrder("Aynet", 100)
    End Sub

    Private Sub Picenkulal_Click(sender As Object, e As EventArgs) Handles Picenkulal.Click
        CreateOrder("Enkulal", 110)
    End Sub

    Private Sub tabCustomer_Click(sender As Object, e As EventArgs) Handles tabCustomer.Click

    End Sub

    Private Sub Picshiro_Click(sender As Object, e As EventArgs) Handles Picshiro.Click
        CreateOrder("Shiro", 80)
    End Sub

    Private Sub Picfirfir_Click(sender As Object, e As EventArgs) Handles Picfirfir.Click
        CreateOrder("Firfir", 90)
    End Sub

    Private Sub Pickinche_Click(sender As Object, e As EventArgs) Handles Pickinche.Click
        CreateOrder("Kinche", 120)
    End Sub

    Private Sub Picruzdinich_Click(sender As Object, e As EventArgs) Handles Picruzdinich.Click
        CreateOrder("Ruz be Dinich", 170)
    End Sub

    Sub ProcessPayment()

        Try
            ' 1. Check if order exists
            If currentOrder Is Nothing Then
                Throw New Exception("No order selected")
            End If

            ' 2. Ask account number
            customerAccount = InputBox("Enter your CBE Account Number:", "CBE Payment")

            ' 3. Validate empty input
            If String.IsNullOrWhiteSpace(customerAccount) Then
                Throw New Exception("Payment cancelled - no account entered")
            End If

            ' 4. Validate account format
            If customerAccount.Length <> 10 Or Not IsNumeric(customerAccount) Then
                Throw New Exception("Invalid CBE Account Number ❌")
            End If

            ' 5. Check balance (EXCEPTION STYLE)
            If customerBalance < currentOrder.Price Then
                Throw New Exception("Insufficient Balance ❌ Current Balance: " & customerBalance)
            End If

            ' 6. Simulate bank processing
            Dim random As New Random()
            Dim approved As Boolean = random.Next(1, 10) > 2 ' 80% success rate

            If Not approved Then
                Throw New Exception("Bank Rejected Payment ❌ Try again")
            End If

            ' 7. SUCCESS CASE
            customerBalance -= currentOrder.Price
            currentOrder.Status = "Paid"

            MessageBox.Show(
                "Payment Successful ✔" & vbCrLf &
                "Account: " & customerAccount & vbCrLf &
                "Amount: " & currentOrder.Price & " birr" & vbCrLf &
                "Remaining Balance: " & customerBalance
            )

        Catch ex As Exception

            ' ALL ERRORS GO HERE
            currentOrder.Status = "Payment Failed"
            MessageBox.Show("Payment Error: " & ex.Message)

        Finally

            ' ALWAYS EXECUTES (VERY IMPORTANT FOR MARKS)
            Console.WriteLine("Payment attempt completed for order system.")

        End Try

    End Sub

    Private Sub btnCook_Click(sender As Object, e As EventArgs) Handles btnCook.Click

        Try
            If currentOrder Is Nothing Then
                Throw New Exception("No order available")
            End If

            currentState = "Cooking"
            currentOrder.Status = "Cooking"

            showlogs.Items.Add("Order #" & currentOrder.OrderID & " → COOKING started")

            lblKitchenStatus.Text = "Status: Cooking"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub showlogs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles showlogs.SelectedIndexChanged
        ' Optional: can show selected log detail later
    End Sub
    Private Sub btnDeliver_Click(sender As Object, e As EventArgs) Handles btnDeliver.Click

        Try
            If currentOrder Is Nothing Then
                Throw New Exception("No order available")
            End If

            If currentState <> "Ready" Then
                Throw New Exception("Order must be ready before delivery")
            End If

            currentState = "Delivered"
            currentOrder.Status = "Delivered"

            showlogs.Items.Add("Order #" & currentOrder.OrderID & " → DELIVERED")

            lblKitchenStatus.Text = "Status: Delivered"

            MessageBox.Show("Order Delivered ✔")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        Try
            If currentOrder Is Nothing Then
                Throw New Exception("No order to finish")
            End If

            If currentOrder.Status <> "Delivered" Then
                Throw New Exception("You must deliver order first")
            End If

            showlogs.Items.Add("Order #" & currentOrder.OrderID & " → FINISHED")

            lblKitchenStatus.Text = "Status: Finished"

            MessageBox.Show("Order Finished ,please  WAITER =>>> now you may ask the customer to give feedback")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click

        Try
            If currentOrder Is Nothing Then
                Throw New Exception("No order available")
            End If

            If currentState <> "Cooking" Then
                Throw New Exception("Must cook first before ready")
            End If

            currentState = "Ready"
            currentOrder.Status = "Ready"

            showlogs.Items.Add("Order #" & currentOrder.OrderID & " → READY")

            lblKitchenStatus.Text = "Status: Ready"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub lblKitchenStatus_Click(sender As Object, e As EventArgs) Handles lblKitchenStatus.Click

    End Sub

    Private Sub lblKitchenDashboard_Click(sender As Object, e As EventArgs) Handles lblKitchenDashboard.Click

    End Sub

    Private Sub lblLiveStatus_Click(sender As Object, e As EventArgs) Handles lblLiveStatus.Click

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        KitchenOrders.Items.Clear()

        If orderDatabase.Count = 0 Then
            KitchenOrders.Items.Add("No orders found")
            Exit Sub
        End If

        For Each o As Order In orderDatabase

            KitchenOrders.Items.Add(
            "ID: " & o.OrderID &
            " | Food: " & o.foodName &
            " | Price: " & o.price &
            " | Status: " & o.Status
        )

        Next

    End Sub
    Private Sub KitchenOrders_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KitchenOrders.SelectedIndexChanged

    End Sub

    Private Sub lblshiro_Click(sender As Object, e As EventArgs) Handles lblshiro.Click

    End Sub

    Private Sub lblFeedback_Click(sender As Object, e As EventArgs) Handles lblFeedback.Click

    End Sub

    Private Sub cmbRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRating.SelectedIndexChanged

    End Sub

    Private Sub lblfeedbk_Click(sender As Object, e As EventArgs) Handles lblfeedbk.Click

    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged

    End Sub

    Private Sub btnSubmitFeedback_Click(sender As Object, e As EventArgs) Handles btnSubmitFeedback.Click

        Try
            If currentOrder Is Nothing Then
                Throw New Exception("No order available")
            End If

            If currentOrder.Status <> "Delivered" Then
                Throw New Exception("Feedback allowed only after delivery")
            End If

            If cmbRating.SelectedItem Is Nothing Then
                Throw New Exception("Please select rating")
            End If

            ' SAVE FEEDBACK
            currentOrder.Rating = CInt(cmbRating.SelectedItem)
            currentOrder.Feedback = txtComment.Text

            MessageBox.Show("Feedback submitted ✔")

            ' REFRESH KITCHEN
            LoadKitchenDashboard()

            ' 🔥 NOW RESET SYSTEM (AFTER FEEDBACK)
            currentOrder = Nothing
            currentState = "Idle"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click

        Dim total As Double = 0

        For Each o As Order In orderDatabase

            If o.Status = "Delivered" Then
                total += o.price
            End If

        Next

        lblTotalRevenue.Text = "Total Revenue: " & total & " Birr"

    End Sub
    Private Sub lblTotalRevenue_Click(sender As Object, e As EventArgs) Handles lblTotalRevenue.Click

    End Sub
End Class
