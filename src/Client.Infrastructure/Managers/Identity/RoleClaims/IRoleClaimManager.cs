﻿using System.Collections.Generic;
using System.Threading.Tasks;
using marketboard.Application.Requests.Identity;
using marketboard.Application.Responses.Identity;
using marketboard.Shared.Wrapper;

namespace marketboard.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}