using System;
using System.Text;

class AgeOutOfRangeException : Exception
{

    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {
    }
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Không thể gửi số tiền âm.");
        }
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Không thể rút số tiền âm.");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Số dư không đủ trong tài khoản.");
        }
        balance -= amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int choice;
        do
        {
            Console.WriteLine("1. Kiểm tra tính đủ điều kiện của học sinh");
            Console.WriteLine("2. Thao tác với tài khoản ngân hàng");
            Console.WriteLine("3. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckEligibility();
                    break;
                case 2:
                    BankAccountOperations();
                    break;
                case 3:
                    Console.WriteLine("Đang thoát...");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        } while (choice != 3);
    }

    static void CheckEligibility()
    {
        try
        {
            Console.Write("Nhập tuổi của học sinh: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException("Tuổi của học sinh phải nằm trong khoảng từ 18 đến 25 (bao gồm) để đủ điều kiện nhập học.");
            }
            Console.WriteLine("Học sinh đủ điều kiện nhập học.");
        }
        catch (AgeOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }

    static void BankAccountOperations()
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Nhập số tiền gửi: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.Write("Nhập số tiền rút: ");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
            Console.WriteLine($"Số dư hiện tại: {account.Balance}");
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
        }
    }
}