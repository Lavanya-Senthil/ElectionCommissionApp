using ElectionCommissionApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ElectionCommissionApp.DAL
{
    public interface IVoter
    {
        List<Voters> GetVoterList { get; }

        bool AddVoter(Voters voter);
        void RemoveVoter();
    }
}
