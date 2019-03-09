﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Should;
using Store.Tests.Unit.Framework;

#pragma warning disable IDE0012 // Simplify Names

namespace F13Works.UnitTests.Framework
{
    [TestFixture]
    public class GetRandomTests
    {
#pragma warning disable IDE1006 // Naming Styles

        private class Element
#pragma warning restore IDE1006 // Naming Styles
        {
            public int Value { get; set; }
        }

        [Test]
        public void BoolTest()
        {
            var actual = GetRandom.Bool();
            actual.ShouldBeType<bool>();
        }

        [Test]
        public void Byte_returns_expected_Byte_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Byte();
            var actual = GetRandom.Byte(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Byte_returns_random_Byte()
        {
            var actual = GetRandom.Byte();
            actual.ShouldBeType<byte>();
        }

        [Test]
        public void Byte_returns_random_Byte_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Byte();
            var minValue = GetRandom.Byte(maxValue);
            var actual = GetRandom.Byte(minValue, maxValue);
            actual.ShouldBeType<byte>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Byte_returns_random_Byte_between_minValue_and_maxValue_with_exclude()
        {
            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Byte(10, 20);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Byte(10, 20, excluded);
            actual.ShouldBeType<byte>();
            actual.ShouldBeGreaterThanOrEqualTo<byte>(10);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo<byte>(20);
        }

        [Test]
        public void Byte_returns_random_Byte_less_than_maxValue()
        {
            var maxValue = GetRandom.Byte();
            var actual = GetRandom.Byte(maxValue);
            actual.ShouldBeType<byte>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void ByteArrayTest()
        {
            var length = GetRandom.Int32(50);
            var actual = GetRandom.ByteArray(length);
            actual.ShouldNotBeNull();
            actual.Length.ShouldEqual(length);
        }

        [Test]
        public void Char_returns_a_random_Char()
        {
            var actual = GetRandom.Char();
            actual.ShouldBeType<char>();
        }

        [Test]
        public void Char_returns_a_random_Char_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Char();
            var minValue = GetRandom.Char(maxValue);
            var actual = GetRandom.Char(minValue, maxValue);
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Char_returns_a_random_Char_less_than_maxValue()
        {
            var maxValue = GetRandom.Char();
            var actual = GetRandom.Char(maxValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void CityName_returns_a_randomly_chosen_city_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.CityName();
            actual.ShouldEqual("Eaton Estates");
        }

        [Test]
        public void DateTime_returns_expected_DateTime_when_minValue_and_maxValue_are_the_same()
        {
            var expected = GetRandom.DateTime();
            var actual = GetRandom.DateTime(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void DateTime_returns_random_DateTime()
        {
            var actual = GetRandom.DateTime();
            actual.ShouldBeType<DateTime>();
        }

        [Test]
        public void DateTime_returns_random_DateTime_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.DateTime();
            var minValue = GetRandom.DateTime(maxValue);
            var actual = GetRandom.DateTime(minValue, maxValue);
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void DateTime_returns_random_DateTime_between_minValue_and_maxValue_with_exclude()
        {
            var minValue = new DateTime();
            var maxValue = minValue.AddMinutes(1);

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.DateTime(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.DateTime(minValue, maxValue, excluded);
            actual.ShouldBeType<DateTime>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void DateTime_returns_random_DateTime_less_than_maxValue()
        {
            var maxValue = GetRandom.DateTime();
            var actual = GetRandom.DateTime(maxValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void DateTimeTest()
        {
            var daysInThePast = GetRandom.Int32(10);
            var daysInTheFuture = GetRandom.Int32(10);
            var now = DateTime.Now;
            var actual = GetRandom.DateTime(daysInThePast, daysInTheFuture);
            actual.ShouldBeInRange(now.AddDays(-daysInThePast), now.AddDays(daysInTheFuture));
        }

        [Test]
        public void Decimal_returns_expected_Decimal_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Decimal();
            var actual = GetRandom.Decimal(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Decimal_returns_random_Decimal()
        {
            var actual = GetRandom.Decimal();
            actual.ShouldBeType<decimal>();
        }

        [Test]
        public void Decimal_returns_random_Decimal_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Decimal();
            var minValue = GetRandom.Decimal(maxValue);
            var actual = GetRandom.Decimal(minValue, maxValue);
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Decimal_returns_random_Decimal_between_minValue_and_maxValue_with_exclude()
        {
            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Decimal(10, 20);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Decimal(10, 20, excluded);
            actual.ShouldBeType<decimal>();
            actual.ShouldBeGreaterThanOrEqualTo(10);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(20);
        }

        [Test]
        public void Decimal_returns_random_Decimal_less_than_maxValue()
        {
            var maxValue = GetRandom.Decimal();
            var actual = GetRandom.Decimal(maxValue);
            actual.ShouldBeType<decimal>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Double_returns_expected_Double_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Double();
            var actual = GetRandom.Double(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Double_returns_random_Double()
        {
            var actual = GetRandom.Double();
            actual.ShouldBeType<double>();
        }

        [Test]
        public void Double_returns_random_Double_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Double();
            var minValue = GetRandom.Double(maxValue);
            var actual = GetRandom.Double(minValue, maxValue);
            actual.ShouldBeType<double>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Double_returns_random_Double_between_minValue_and_maxValue_with_exclude()
        {
            var minValue = 10;
            var maxValue = 20;

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Double(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Double(minValue, maxValue, excluded);
            actual.ShouldBeType<double>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Double_returns_random_Double_less_than_maxValue()
        {
            var maxValue = GetRandom.Double();
            var actual = GetRandom.Double(maxValue);
            actual.ShouldBeType<double>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Element_returns_all_elements_from_list()
        {
            var elements = new[]
            {
                new Element(),
                new Element(),
                new Element(),
                new Element(),
                new Element()
            };

            while (elements.Any(x => x.Value < 100))
            {
                GetRandom.Element(elements).Value++;
            }
        }

        [Test]
        public void Element_returns_random_element_from_list()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var actual = GetRandom.Element(list);
            actual.ShouldBeGreaterThanOrEqualTo(1);
            actual.ShouldBeLessThanOrEqualTo(5);
        }

        [Test]
        public void Element_returns_random_element_from_list_with_exclude()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            var actual = GetRandom.Element(list, 3);
            actual.ShouldBeGreaterThanOrEqualTo(1);
            actual.ShouldNotEqual(3);
            actual.ShouldBeLessThanOrEqualTo(5);
        }

        [Test]
        public void EnumValue_returns_random_enumeration_value()
        {
            var actual = GetRandom.EnumValue<DayOfWeek>();
            actual.ShouldBeType<DayOfWeek>();
            Enum.IsDefined(typeof(DayOfWeek), actual).ShouldBeTrue();
        }

        [Test]
        public void EnumValue_returns_random_enumeration_value_with_exclude()
        {
            var notExpected = GetRandom.EnumValue<DayOfWeek>();
            var actual = GetRandom.EnumValue(notExpected);
            actual.ShouldBeType<DayOfWeek>();
            Enum.IsDefined(typeof(DayOfWeek), actual).ShouldBeTrue();
            actual.ShouldNotEqual(notExpected);
        }

        [Test]
        public void EnumValue_throws_ArgumentException_for_non_enumeration_type_parameter()
        {
            Action action = () => GetRandom.EnumValue<string>();
            action.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void EnumValue_with_exclude_throws_ArgumentException_for_non_enumeration_type_parameter()
        {
            Action action = () => GetRandom.EnumValue(string.Empty);
            action.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void FirstName_false_returns_a_randomly_chosen_female_first_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.FirstName(false);
            actual.ShouldEqual("Cassidy");
        }

        [Test]
        public void FirstName_returns_a_randomly_chosen_first_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.FirstName();
            actual.ShouldEqual("Bradley");
        }

        [Test]
        public void FirstName_true_returns_a_randomly_chosen_male_first_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.FirstName(true);
            actual.ShouldEqual("Conner");
        }

        [Test]
        public void Int16_returns_expected_Int16_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Int16();
            var actual = GetRandom.Int16(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Int16_returns_random_Int16()
        {
            var actual = GetRandom.Int16();
            actual.ShouldBeType<short>();
        }

        [Test]
        public void Int16_returns_random_Int16_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Int16();
            var minValue = GetRandom.Int16(maxValue);
            var actual = GetRandom.Int16(minValue, maxValue);
            actual.ShouldBeType<short>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int16_returns_random_Int16_between_minValue_and_maxValue_with_exclude()
        {
            short minValue = 10;
            short maxValue = 20;

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Int16(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Int16(minValue, maxValue, excluded);
            actual.ShouldBeType<short>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int16_returns_random_Int16_less_than_maxValue()
        {
            var maxValue = GetRandom.Int16();
            var actual = GetRandom.Int16(maxValue);
            actual.ShouldBeType<short>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int32_returns_expected_Int32_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Int32();
            var actual = GetRandom.Int32(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Int32_returns_random_Int32()
        {
            var actual = GetRandom.Int32();
            actual.ShouldBeType<int>();
        }

        [Test]
        public void Int32_returns_random_Int32_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Int32();
            var minValue = GetRandom.Int32(maxValue);
            var actual = GetRandom.Int32(minValue, maxValue);
            actual.ShouldBeType<int>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int32_returns_random_Int32_between_minValue_and_maxValue_with_exclude()
        {
            var minValue = 10;
            var maxValue = 20;

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Int32(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Int32(minValue, maxValue, excluded);
            actual.ShouldBeType<int>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int32_returns_random_Int32_less_than_maxValue()
        {
            var maxValue = GetRandom.Int32();
            var actual = GetRandom.Int32(maxValue);
            actual.ShouldBeType<int>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int32IdTest()
        {
            GetRandom.SetNextId(1);
            GetRandom.Id().ShouldEqual(1);
            GetRandom.Id().ShouldEqual(2);
        }

        [Test]
        public void Int64_returns_expected_Int64_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Int64();
            var actual = GetRandom.Int64(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Int64_returns_random_Int64()
        {
            var actual = GetRandom.Int64();
            actual.ShouldBeType<long>();
        }

        [Test]
        public void Int64_returns_random_Int64_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Int64();
            var minValue = GetRandom.Int64(maxValue);
            var actual = GetRandom.Int64(minValue, maxValue);
            actual.ShouldBeType<long>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int64_returns_random_Int64_between_minValue_and_maxValue_with_exclude()
        {
            long minValue = 10;
            long maxValue = 20;

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Int64(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Int64(minValue, maxValue, excluded);
            actual.ShouldBeType<long>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Int64_returns_random_Int64_less_than_maxValue()
        {
            var maxValue = GetRandom.Int64();
            var actual = GetRandom.Int64(maxValue);
            actual.ShouldBeType<long>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void LastName_returns_a_randomly_chosen_last_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.LastName();
            actual.ShouldEqual("Dotson");
        }

        [Test]
        public void Name_returns_a_randomly_constructed_first_and_last_name()
        {
            GetRandom.Random = new Random(1);
            var actual = GetRandom.Name();
            actual.ShouldEqual("Bradley Jackson");
        }

        [Test]
        public void PrefixTest()
        {
            var expected = GetRandom.String();
            var prefixLength = expected.Length;

            GetRandom.StringPrefix = expected;
            var actual = GetRandom.StringPrefix;
            actual.ShouldEqual(expected);

            GetRandom.String(prefixLength, prefixLength).ShouldEqual(expected);
        }

        [Test]
        public void RandomTest()
        {
            var expected = new Random();
            GetRandom.Random = expected;
            var actual = GetRandom.Random;
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Single_returns_expected_Single_when_minValue_and_maxValue_are_same()
        {
            var expected = GetRandom.Single();
            var actual = GetRandom.Single(expected, expected);
            actual.ShouldEqual(expected);
        }

        [Test]
        public void Single_returns_random_Single()
        {
            var actual = GetRandom.Single();
            actual.ShouldBeType<float>();
        }

        [Test]
        public void Single_returns_random_Single_between_minValue_and_maxValue()
        {
            var maxValue = GetRandom.Single();
            var minValue = GetRandom.Single(maxValue);
            var actual = GetRandom.Single(minValue, maxValue);
            actual.ShouldBeType<float>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Single_returns_random_Single_between_minValue_and_maxValue_with_exclude()
        {
            float minValue = 10;
            float maxValue = 20;

            GetRandom.Random = new Random(0);
            var excluded = GetRandom.Single(minValue, maxValue);
            GetRandom.Random = new Random(0);

            var actual = GetRandom.Single(minValue, maxValue, excluded);
            actual.ShouldBeType<float>();
            actual.ShouldBeGreaterThanOrEqualTo(minValue);
            actual.ShouldNotEqual(excluded);
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void Single_returns_random_Single_less_than_maxValue()
        {
            var maxValue = GetRandom.Single();
            var actual = GetRandom.Single(maxValue);
            actual.ShouldBeType<float>();
            actual.ShouldBeLessThanOrEqualTo(maxValue);
        }

        [Test]
        public void String_returns_random_String_between_minLength_and_maxLength_chars()
        {
            var maxLength = GetRandom.Int32(100, 256);
            var minLength = GetRandom.Int32(1, maxLength);
            var actual = GetRandom.String(minLength, maxLength);
            var prefix = GetRandom.StringPrefix;
            actual.Substring(0, prefix.Length).ShouldEqual(prefix);
            actual.Length.ShouldBeGreaterThanOrEqualTo(minLength);
            actual.Length.ShouldBeLessThanOrEqualTo(maxLength);
        }

        [Test]
        public void String_returns_random_String_between_minLength_and_maxLength_chars_with_exclude()
        {
            var prefix = GetRandom.StringPrefix;
            var maxLength = GetRandom.Int32(10, 256);
            var minLength = GetRandom.Int32(prefix.Length, maxLength);
            var notExpected = GetRandom.String(minLength, maxLength);
            var actual = GetRandom.String(minLength, maxLength, notExpected);
            actual.Substring(0, prefix.Length).ShouldEqual(prefix);
            actual.Length.ShouldBeGreaterThanOrEqualTo(minLength);
            actual.Length.ShouldBeLessThanOrEqualTo(maxLength);
            actual.ShouldNotEqual(notExpected);
        }

        [Test]
        public void String_returns_random_String_of_50_chars_or_less()
        {
            var actual = GetRandom.String();
            actual.Length.ShouldBeLessThanOrEqualTo(50);
        }

        [Test]
        public void String_returns_random_string_of_expected_length_when_minLength_and_maxLength_are_the_same()
        {
            var length = GetRandom.Int32(256);
            var actual = GetRandom.String(length, length);
            actual.Length.ShouldEqual(length);
        }

        [Test]
        public void String_returns_random_String_of_maxLength_chars_or_less()
        {
            var prefix = GetRandom.StringPrefix;
            var maxLength = GetRandom.Int32(1 + prefix.Length, 256);
            var actual = GetRandom.String(prefix.Length, maxLength);
            actual.Substring(0, prefix.Length).ShouldEqual(prefix);
            actual.Length.ShouldBeLessThanOrEqualTo(maxLength);
        }
    }
}

#pragma warning restore IDE0012 // Simplify Names
