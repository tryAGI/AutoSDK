using System.Globalization;
using AutoSDK.Models;

namespace AutoSDK.Naming;

internal static class CSharpIdentifierCharacterRules
{
    public static int GetCodePointLength(string text, int index)
    {
        return index + 1 < text.Length && char.IsSurrogatePair(text, index)
            ? 2
            : 1;
    }

    public static bool IsValidIdentifierStart(string text, int index, IdentifierCharacterSet identifierCharacterSet)
    {
        if (text[index] == '_')
        {
            return true;
        }

        return identifierCharacterSet switch
        {
            IdentifierCharacterSet.Ascii => IsAsciiLetter(text[index]),
            IdentifierCharacterSet.UnicodeLetters => !char.IsSurrogate(text[index]) && char.IsLetter(text[index]),
            IdentifierCharacterSet.CSharpSpec => IsCSharpSpecStart(text, index),
            _ => false,
        };
    }

    public static bool IsValidIdentifierPart(string text, int index, IdentifierCharacterSet identifierCharacterSet)
    {
        if (text[index] == '_')
        {
            return true;
        }

        return identifierCharacterSet switch
        {
            IdentifierCharacterSet.Ascii => IsAsciiLetter(text[index]) || IsAsciiDigit(text[index]),
            IdentifierCharacterSet.UnicodeLetters => !char.IsSurrogate(text[index]) && char.IsLetterOrDigit(text[index]),
            IdentifierCharacterSet.CSharpSpec => IsCSharpSpecPart(text, index),
            _ => false,
        };
    }

    public static string TrimLeadingInvalidSourceCharacters(string text, IdentifierCharacterSet identifierCharacterSet)
    {
        for (var i = 0; i < text.Length; i += GetCodePointLength(text, i))
        {
            if (ShouldKeepLeadingSourceCharacter(text, i, identifierCharacterSet))
            {
                return text.Substring(i);
            }
        }

        return string.Empty;
    }

    public static bool LooksLikeGeneratedIdentifier(string text, IdentifierCharacterSet identifierCharacterSet)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        if (identifierCharacterSet == IdentifierCharacterSet.CSharpSpec)
        {
            if (!IsValidIdentifierStart(text, 0, identifierCharacterSet))
            {
                return false;
            }
        }
        else if (!char.IsUpper(text[0]) && text[0] != '_')
        {
            return false;
        }

        for (var i = GetCodePointLength(text, 0); i < text.Length; i += GetCodePointLength(text, i))
        {
            if (!IsValidIdentifierPart(text, i, identifierCharacterSet))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsCSharpSpecStart(string text, int index)
    {
        return CharUnicodeInfo.GetUnicodeCategory(text, index) is
            UnicodeCategory.UppercaseLetter or
            UnicodeCategory.LowercaseLetter or
            UnicodeCategory.TitlecaseLetter or
            UnicodeCategory.ModifierLetter or
            UnicodeCategory.OtherLetter or
            UnicodeCategory.LetterNumber;
    }

    private static bool IsCSharpSpecPart(string text, int index)
    {
        return CharUnicodeInfo.GetUnicodeCategory(text, index) is
            UnicodeCategory.UppercaseLetter or
            UnicodeCategory.LowercaseLetter or
            UnicodeCategory.TitlecaseLetter or
            UnicodeCategory.ModifierLetter or
            UnicodeCategory.OtherLetter or
            UnicodeCategory.LetterNumber or
            UnicodeCategory.DecimalDigitNumber or
            UnicodeCategory.ConnectorPunctuation or
            UnicodeCategory.NonSpacingMark or
            UnicodeCategory.SpacingCombiningMark or
            UnicodeCategory.Format;
    }

    private static bool IsAsciiDigit(char ch)
    {
        return ch is >= '0' and <= '9';
    }

    private static bool ShouldKeepLeadingSourceCharacter(string text, int index, IdentifierCharacterSet identifierCharacterSet)
    {
        return identifierCharacterSet switch
        {
            IdentifierCharacterSet.Ascii => GetCodePointLength(text, index) == 1 && (IsAsciiLetter(text[index]) || IsAsciiDigit(text[index])),
            IdentifierCharacterSet.UnicodeLetters => GetCodePointLength(text, index) == 1 && (char.IsLetter(text[index]) || char.IsDigit(text[index])),
            IdentifierCharacterSet.CSharpSpec => IsValidIdentifierStart(text, index, identifierCharacterSet) ||
                                                 CharUnicodeInfo.GetUnicodeCategory(text, index) == UnicodeCategory.DecimalDigitNumber,
            _ => false,
        };
    }

    private static bool IsAsciiLetter(char ch)
    {
        return ch is >= 'A' and <= 'Z' or >= 'a' and <= 'z';
    }
}
