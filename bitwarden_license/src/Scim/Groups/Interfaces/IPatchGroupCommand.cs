﻿using Bit.Core.AdminConsole.Entities;
using Bit.Scim.Models;

namespace Bit.Scim.Groups.Interfaces;

public interface IPatchGroupCommand
{
    Task PatchGroupAsync(Group group, ScimPatchModel model);
}
