﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.79.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Cron.Test
{
    using global::System.CodeDom.Compiler;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;
    
    using global::OBeautifulCode.Assertion.Recipes;

    using global::Xunit;

    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.79.0")]
    public static partial class CronDummyFactoryTest
    {
        [Fact]
        public static void CronDummyFactory___Should_derive_from_DefaultCronDummyFactory___When_reflecting()
        {
            // Arrange
            var dummyFactoryType = typeof(CronDummyFactory);

            var defaultDummyFactoryType = typeof(DefaultCronDummyFactory);

            // Act, Assert
            defaultDummyFactoryType.GetInterface(nameof(IDummyFactory)).AsTest().Must().NotBeNull();

            dummyFactoryType.BaseType.AsTest().Must().BeEqualTo(defaultDummyFactoryType);
        }
    }
}