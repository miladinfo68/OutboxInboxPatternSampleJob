﻿namespace Receiver.Commands
{
    public record SendEmailCommand(string Id, string Email, string Body)
    {
    }
}