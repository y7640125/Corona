using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Interfaces
{
    public interface IMemberDAL
    {
        bool AddMember(Member member);
        bool DeleteMember(int id);
        List<Member> GetAllMembers();
        Member getMemberById(int memberId);
        Member getMemberByTz(string tz);
        int GetUnvaccinatedMembers();
        int GetSicksPerMonth(int month);
        bool UpdateMember(Member member, int id);

    }
}