using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MemberDAL : IMemberDAL
    {
        CoronaContext _context = new CoronaContext();
        public List<Member> GetAllMembers()
        {
            try
            {
                return _context.Members.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Member getMemberById(int memberId)
        {
            Member member = _context.Members.SingleOrDefault(x => x.Id.Equals(memberId));
            return member;
        }
        public Member getMemberByTz(string tz)
        {
            Member member = _context.Members.SingleOrDefault(x => x.Tz.Equals(tz));
            return member;
        }
        public int GetUnvaccinatedMembers()
        {
            var x = _context.Members.Include(vac =>
            vac.Vaccinations).ToList();
            x.Where(x => x.Id == null).ToList();
            return x.Count();
        }
        public int GetSicksPerMonth(int month)
        {
            Member member = _context.Members.SingleOrDefault(x => x.Id.Equals(2003));
            var y = member.PositiveAnswerDate.Value.Month;
            var x = _context.Members.Where(x => x.PositiveAnswerDate.Value.Month.Equals(month)).ToList();
            return x.Count();
        }
        public bool AddMember(Member member)
        {
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteMember(int id)
        {
            try
            {
                Member member = _context.Members.SingleOrDefault(x => x.Id == id);
                _context.Members.Remove(member);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateMember(Member member, int id)
        {
            try
            {
                Member currentMember = _context.Members.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentMember).CurrentValues.SetValues(member);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
