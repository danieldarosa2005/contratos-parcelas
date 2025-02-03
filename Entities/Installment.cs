using System.Globalization;

class Installment {
    public DateTime dueDate { get; set; } //data de vencimento
    public double Amount { get; set; } //quantia


    public Installment(DateTime duedate, double amount) {
        dueDate = duedate;
        Amount = amount;
    }
    public override string ToString()
    {
        return dueDate.ToString("dd/MM/yyyy")
        + " - "
        + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
        }