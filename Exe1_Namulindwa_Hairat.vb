Public Class BankAccount

    Private _balance As Decimal

    'Read-only Balance property
    Public ReadOnly Property Balance As Decimal
        Get
            Return _balance
        End Get
    End Property

    'Deposit money
    Public Sub Deposit(amount As Decimal)
        If amount < 0 Then
            Throw New ArgumentException("Deposit amount cannot be negative.")
        End If

        _balance += amount
    End Sub

    'Withdraw money
    Public Sub Withdraw(amount As Decimal)
        If amount < 0 Then
            Throw New ArgumentException("Withdrawal amount cannot be negative.")
        End If

        If amount > _balance Then
            Throw New InvalidOperationException("Insufficient funds.")
        End If

        _balance -= amount
    End Sub

End Class
