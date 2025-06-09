## Tools to work with IBAN, BBAN, Their validation

### امکانات کار با شماره شبا برای بانک های ایران

<br >

IBAN - شماره شبا

BBAN - شماره حساب

<br >

Functions
* turnBbanIntoIban
* turnIbanIntoBban
* isIbanValid
* tokenizeIban
* isBankCodeValid
* getBankNameFromIban
* formatIban

<br >

#### **isIbanValid**
این تابع مشخص میکند که آیا شماره شبا معتبر است و یا خیر


#### **turnBbanIntoIban**
این تابع شماره حساب را به شماره شبا تبدیل میکند

bban: `string`

bankCode: string -- use enum `BANK_COES` for example `BANK_CODES.TEJARAT`

bbanType = "0" -- `optional`

`0` یعنی حساب سپرده

`1` یعنی حساب تسهیلات

countryCode = "IR" -- `optional`

<br >


example
```c#
var bban = "0351184689007"; var iban = TurnBbanIntoIban.Convert(bban, IranIbanEnums.BankCodes["MELLI"]); Console.WriteLine($"(done) bban: {bban} iban: {iban}");
```

#### **tokenizeIban**
یک آبجکت از ساختار سازنده شماره شبا در خروجی میدهد و اگر شماره شبا نا معتبر بود آبجکت خالی میدهد

It returns the tokenized iban via object or returns an empty object if iban was not valid

<br >

exmaple

```c#
var iban = "IR870570028180010653892101"; 
var tokenized = TokenizeIban.Tokenize(iban);
Console.WriteLine($"function tokenizedIban: [input] iban {iban} [result] Country={tokenized?.CountryCode}, CD={tokenized?.CD}, CC={tokenized?.CC}, bbanType = {tokenized?.BbanType}, BBAN={tokenized?.BBAN}");
// {
//  countryCode: "IR",
//  CD: "87",
//  CC: "057",
//  bbanType: "0",
//  BBAN: "028180010653892101"
// }
```

#### **getBankNameFromIban**
با توجه به شماره شبا نام فارسی بانک را بر می گرداند

<br >

example
```js
var iban = "IR870180028180010653892101";
var farsiBankName = GetBankNameFromIban.GetName(iban);
// output: "بانک تجارت"
```

#### **isBankCodeValid**
این تابع مشخص میکند که آیا کد بانک معتبر است و یا خیر

you can get bank codes from enum `BANK_CODES`

example

```js
var isValid = isBankCodeValid("018"); // 018 is BANK_CODES.TEJARAT
// output: true
```

#### **formatIban**
شماره شبا را به فرم استاندارد در خروجی می دهد

```c#
var iban = "IR870570028180010653892101";
var formattedIban = FormatIban.Format(iban);
// output: IR87 0570 0281 8001 0653 8921 01 
```

<br >
