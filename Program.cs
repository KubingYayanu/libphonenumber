using PhoneNumbers;
using System;

namespace libphonenumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var builder = PhoneNumber.CreateBuilder();
            //builder.SetRawInput("0963382030");
            //builder.SetCountryCode(886);
            //var phoneNumber = builder.Build();
            //var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            //var isValidNumber = phoneNumberUtil.IsValidNumberForRegion(phoneNumber, "886");

            var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            //var builder = PhoneNumber.CreateBuilder();

            var fixedLine = "039386080";
            var shortFixedLine = "39386080";
            var mobile = "0963382030";
            var nationalMobile = "+886963382030";
            var wrongMobile = "886923456789";

            var phoneNumberFixedLine = phoneNumberUtil.ParseAndKeepRawInput(fixedLine, "TW");
            var phoneNumberShortFixedLine = phoneNumberUtil.ParseAndKeepRawInput(shortFixedLine, "TW");
            var phoneNumberMobile = phoneNumberUtil.ParseAndKeepRawInput(mobile, "TW");
            var phoneNumberNationalMobile = phoneNumberUtil.ParseAndKeepRawInput(nationalMobile, "TW");
            var phoneNumberWrongMobile = phoneNumberUtil.ParseAndKeepRawInput(wrongMobile, "TW");
            
            var isValidNumberFixedLine = phoneNumberUtil.IsValidNumber(phoneNumberFixedLine);
            var isValidNumberShortFixedLine = phoneNumberUtil.IsValidNumber(phoneNumberShortFixedLine);
            var isValidNumberMobile = phoneNumberUtil.IsValidNumber(phoneNumberMobile);
            var isValidNumberNationMobile = phoneNumberUtil.IsValidNumber(phoneNumberNationalMobile);

            Console.WriteLine($"Fixed Line: {fixedLine}, {isValidNumberFixedLine}");
            Console.WriteLine($"Short Fixed Line: {shortFixedLine}, {isValidNumberShortFixedLine}");
            Console.WriteLine($"Mobile: {mobile}, {isValidNumberMobile}");
            Console.WriteLine($"National Mobile: {nationalMobile}, {isValidNumberNationMobile}");
            Console.WriteLine($"Worng mobile: {wrongMobile}, {phoneNumberUtil.IsValidNumber(phoneNumberWrongMobile)}");
            Console.WriteLine($"Mobile Token: {PhoneNumberUtil.GetCountryMobileToken(886)}");
        }
    }
}