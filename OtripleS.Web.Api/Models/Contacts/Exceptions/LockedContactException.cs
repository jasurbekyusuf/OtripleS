﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.Contacts.Exceptions
{
    public class LockedContactException : Exception
    {
        public LockedContactException(Exception innerException)
            : base(message: "Locked contact record exception, please try again later.", innerException) { }
    }
}
