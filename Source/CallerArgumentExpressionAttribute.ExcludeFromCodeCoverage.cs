// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="CallerArgumentExpressionAttribute.ExcludeFromCodeCoverage.cs" company="Syntony">
//     Copyright © 2017 - 2024 by Syntony® / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.
// </copyright>
// <author>Josef Hahnl - Josef</author>
// <email>syntony@aon.at</email>
// <date>24.01.2024 16:16:04</date>
// <information solution="Syntony.Common.Nullable" project="Syntony.Common.Nullable" framework=".NETStandard,Version=v1.0" kind="Windows (C# - csproj)">
//     <file type=".cs" created="24.01.2024 16:12:57" modified="24.01.2024 16:16:04" lastAccess="24.01.2024 16:16:04">
//         D:\Syntony\Proj\Syntony\Framework\Source\Syntony.Common.Nullable\Source\CallerArgumentExpressionAttribute.ExcludeFromCodeCoverage.cs
//     </file>
//     <lineStatistics total="47" netLines="44" blankLines ="3" codeLines="42" codeRatio="89.36 %" allCommentLines="26" commentLines="1" headerLines="25" documentationLines="2"/>
//     <language>.cs</language>
//     <namespace>System.Runtime.CompilerServices</namespace>
//     <class>CallerArgumentExpressionAttribute</class>
//     <identifiers>
//         <Namespace>System.Runtime.CompilerServices</Namespace>
//         <Class>CallerArgumentExpressionAttribute</Class>
//         <Record>CallerArgumentExpressionAttribute</Record>
//     </identifiers>
// </information>
// <summary>
//     Specifies that <see langword="null"/> is disallowed as an input even if the corresponding type allows it.
// </summary>
// -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#if !NULLABLE_ATTRIBUTES_DISABLE
#nullable enable
#pragma warning disable

namespace System.Runtime.CompilerServices
{
    using global::System;

#if DEBUG
    /// <summary>Specifies that <see langword="null"/> is disallowed as an input even if the corresponding type allows it.</summary>
    /// <devdoc><a href="https://github.com/dotnet/aspnetcore/blob/main/src/Shared/CallerArgument/CallerArgumentExpressionAttribute.css"/></devdoc>
#endif
#if !NULLABLE_ATTRIBUTES_INCLUDE_IN_CODE_COVERAGE
    [Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
    internal sealed partial class CallerArgumentExpressionAttribute : Attribute
    { }
}

#pragma warning restore
#nullable restore
#endif // NULLABLE_ATTRIBUTES_DISABLE
