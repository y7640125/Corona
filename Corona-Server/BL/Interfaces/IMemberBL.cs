using DTO;

namespace BL.Interfaces
{
    public interface IMemberBL
    {
        bool AddMember(MemberDTO member);
        bool DeleteMember(int id);
        List<MemberDTO> GetAllMembers();
        MemberDTO getMemberById(int memberId);
        MemberDTO getMemberByTz(string tz);
        int GetUnvaccinatedMembers();
        int GetSicksPerMonth(int month);
        bool UpdateMember(MemberDTO Member, int id);
         
    }
}