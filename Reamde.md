# Assalamu Aleykum 👋

## 📌 Fibonacci Sonlar Ketma-ketligi

**Fibonacci** — bu sonlar ketma-ketligi bo‘lib, har bir son o‘zidan oldingi ikki sonning yig‘indisiga teng bo‘ladi. Ketma-ketlik odatda **0** va **1** sonlari bilan boshlanadi.

### 🔢 Misol:

Har bir keyingi son quyidagicha hisoblanadi:

- `0 + 1 = 1`
- `1 + 1 = 2`
- `1 + 2 = 3`
- `2 + 3 = 5`
- `3 + 5 = 8`
- ...

Ya’ni, uchinchi indeksdagi qiymat **1** bo‘ladi, to‘rtinchisi esa **2**, beshinchisi — **3** va hokazo.

---

## ❓ Buni qanday qilish mumkin?

Quyidagi C# kod yordamida **Fibonacci** sonini hisoblash mumkin:

```csharp
BigInteger a = 0;
BigInteger b = 1;

await Task.Yield();

for (BigInteger i = 1; i < number; i++)
{
    if (a == 0)
        a++;
    else
    {
        BigInteger temp = a;
        a = b;
        b = temp + b;
    }
}

Console.WriteLine("Result: " + a);
Console.Write("Enter the number: ");
```

# 📃Chuntirish

Biz dastlab `BigInteger` turida a va b o‘zgaruvchilarini yaratamiz va ularga 0 hamda 1 qiymatlarini beramiz.

`await Task.Yield();` — bu metod asinxronlikni ta'minlaydi. Metod fon rejimida ishlashni boshlaydi.

for sikli orqali `Fibonacci` algoritmi bosqichma-bosqich hisoblanadi.

Quyidagi qism Fibonacci formulasi:
```csharp
BigInteger temp = a;
a = b;
b = temp + b;
```


