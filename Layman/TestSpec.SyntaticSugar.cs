﻿// ~ Generated by TestSpec.SyntaticSugar.tt
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Layman
{
    partial class TestSpec
    {
        protected void and(string description, Func<bool> check)
        {
            It(description, check);
        }

        protected void that(string description, Func<bool> check)
        {
            It(description, check);
        }

        protected void then(string description, Func<bool> check)
        {
            It(description, check);
        }

        protected void and(Func<bool> check)
        {
            It(check);
        }

        protected void that(Func<bool> check)
        {
            It(check);
        }

        protected void then(Func<bool> check)
        {
            It(check);
        }

        protected void and(string description, Action check)
        {
            It(description, check);
        }

        protected void that(string description, Action check)
        {
            It(description, check);
        }

        protected void then(string description, Action check)
        {
            It(description, check);
        }

        protected void and(Action check)
        {
            It(check);
        }

        protected void that(Action check)
        {
            It(check);
        }

        protected void then(Action check)
        {
            It(check);
        }

    }
}
