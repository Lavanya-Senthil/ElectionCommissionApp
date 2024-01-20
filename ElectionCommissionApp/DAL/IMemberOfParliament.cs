using ElectionCommissionApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ElectionCommissionApp.DAL
{
    public interface IMemberOfParliament
    {
        List<Candidate> getCandidateList();
        void AddCandidate();
        void RemoveCandidate();
    }
}
