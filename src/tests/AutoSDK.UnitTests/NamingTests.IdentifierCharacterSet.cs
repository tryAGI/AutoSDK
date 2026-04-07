using AutoSDK.Models;
using AutoSDK.Naming.Clients;
using AutoSDK.Naming.Properties;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    public void AsciiIdentifierCharacterSet_SanitizesNonAsciiLetters()
    {
        var sanitized = CSharpPropertyNameGenerator.SanitizeName(
            "ÆValue",
            "x",
            skipHandlingWordSeparators: true,
            identifierCharacterSet: IdentifierCharacterSet.Ascii);

        sanitized.Should().Be("x_Value");
    }

    [TestMethod]
    public void UnicodeLettersIdentifierCharacterSet_PreservesCommonNonAsciiLetters()
    {
        var sanitized = CSharpPropertyNameGenerator.SanitizeName(
            "ÆØÅValue",
            "x",
            skipHandlingWordSeparators: true,
            identifierCharacterSet: IdentifierCharacterSet.UnicodeLetters);

        sanitized.Should().Be("ÆØÅValue");
    }

    [TestMethod]
    public void CSharpSpecIdentifierCharacterSet_PreservesAdditionalValidIdentifierCategories()
    {
        CSharpPropertyNameGenerator.SanitizeName(
                "Ⅻ",
                "x",
                skipHandlingWordSeparators: true,
                identifierCharacterSet: IdentifierCharacterSet.CSharpSpec)
            .Should().Be("Ⅻ");

        CSharpPropertyNameGenerator.SanitizeName(
                "e\u0301",
                "x",
                skipHandlingWordSeparators: true,
                identifierCharacterSet: IdentifierCharacterSet.CSharpSpec)
            .Should().Be("e\u0301");
    }

    [TestMethod]
    public void CSharpSpecIdentifierCharacterSet_PreservesSupplementaryLetters()
    {
        var sanitized = CSharpPropertyNameGenerator.SanitizeName(
            "\U00010400Model",
            "x",
            skipHandlingWordSeparators: true,
            identifierCharacterSet: IdentifierCharacterSet.CSharpSpec);

        sanitized.Should().Be("\U00010400Model");
    }

    [TestMethod]
    public void ClientNames_UseConfiguredIdentifierCharacterSet()
    {
        var defaultSettings = CSharpSettings.Default with
        {
            IdentifierCharacterSet = IdentifierCharacterSet.UnicodeLetters,
            ClsCompliantEnumPrefix = "x",
        };
        var fullSpecSettings = defaultSettings with
        {
            IdentifierCharacterSet = IdentifierCharacterSet.CSharpSpec,
        };

        CSharpClientNameGenerator.GeneratePropertyName(defaultSettings, "Ⅻ tools")
            .Should().Be("Tools");
        CSharpClientNameGenerator.GeneratePropertyName(fullSpecSettings, "Ⅻ tools")
            .Should().Be("ⅫTools");
    }
}
