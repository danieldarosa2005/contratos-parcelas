interface IOnlinePaymentService {
    double PaymentFee(double Amount); //calcula a taxa de pagamento.
    double Interest(double Amount, int months); //calcula os juros com base no valor e meses.
}
