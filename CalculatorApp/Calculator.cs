using System;

internal class Calculator : AbstractBase
{
    public override int Add(int a, int b)
    {
        return a + b;
    }
    public override int Mul(int a, int b)
    {
        return a * b;
    }
    public override int Sub(int a, int b)
    {
        return a - b;
    }
    public override int Div(int a, int b)
    {
        return a / b;
    }
}
