﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquatableTestScenario{T}.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in OBeautifulCode.CodeGen.ModelObject.Recipes source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.CodeGen.ModelObject.Recipes
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    using OBeautifulCode.CodeGen.ModelObject.Recipes.Internal;

    /// <summary>
    /// Specifies a scenario for equality tests.
    /// </summary>
    /// <typeparam name="T">The type of the object being tested.</typeparam>
#if !OBeautifulCodeCodeGenRecipesProject
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("OBeautifulCode.CodeGen.ModelObject.Recipes", "See package version number")]
    internal
#else
    public
#endif
    class EquatableTestScenario<T>
        where T : class
    {
        /// <summary>
        /// Gets or sets the name of the scenario.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a reference object.
        /// </summary>
        public T ReferenceObject { get; set; }

        /// <summary>
        /// Gets or sets objects that are equal to but not the same object in-memory as the <see cref="ReferenceObject"/>.
        /// </summary>
        public IReadOnlyList<T> ObjectsThatAreEqualToButNotTheSameAsReferenceObject { get; set; }

        /// <summary>
        /// Gets or sets objects that are not equal to the <see cref="ReferenceObject"/>.
        /// </summary>
        public IReadOnlyList<T> ObjectsThatAreNotEqualToReferenceObject { get; set; }

        /// <summary>
        /// Gets or sets objects that derive from <typeparamref name="T"/>, but are not of the same type as the <see cref="ReferenceObject"/>.
        /// </summary>
        public IReadOnlyList<T> ObjectsThatDeriveFromScenarioTypeButAreNotOfTheSameTypeAsReferenceObject { get; set; }

        /// <summary>
        /// Gets or sets objects that are not of the same type as the <see cref="ReferenceObject"/>.
        /// </summary>
        public IReadOnlyList<object> ObjectsThatAreNotOfTheSameTypeAsReferenceObject { get; set; }

        /// <summary>
        /// Gets a scenario to use when you need to force the consuming unit tests to pass and you intend to write your own unit tests.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Justification = ObcSuppressBecause.CA1000_DoNotDeclareStaticMembersOnGenericTypes_StaticPropertyReturnsInstanceOfContainingGenericClassAndIsConvenientAndMostDiscoverableWhereDeclared)]
        public static EquatableTestScenario<T> ForceGeneratedTestsToPassAndWriteMyOwnScenario =>
            new EquatableTestScenario<T>
            {
                Name = "force generated unit tests to pass, i'll write my own",
                ReferenceObject = (T)FormatterServices.GetUninitializedObject(typeof(T)),
            };
    }
}
