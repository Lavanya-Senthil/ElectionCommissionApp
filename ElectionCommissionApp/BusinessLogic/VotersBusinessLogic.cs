using ElectionCommissionApp.DAL;
using ElectionCommissionApp.Data;
using ElectionCommissionApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectionCommissionApp.BusinessLogic
{
    public class VotersBusinessLogic : IVoter
    {
        private readonly ElectionCommissionAppContext _context;
        public VotersBusinessLogic(ElectionCommissionAppContext context) {
            _context = context;
        }

        bool IVoter.AddVoter(Voters voter)
        {
            try
            {
                _context.Add(voter);
                _context.SaveChangesAsync();
                return true;
            }
            catch //Can able to log the exception in application insights/storage acoount etc
            {
                return false;
            }
        }

        List<Voters> IVoter.GetVoterList => _context.Voters.ToList();

        void IVoter.RemoveVoter()
        {
            throw new NotImplementedException();
        }
    }
}
