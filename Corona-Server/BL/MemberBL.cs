using AutoMapper;
using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;

namespace BL
{
    public class MemberBL : IMemberBL
    {
        IMemberDAL _memberDAL;
        IMapper mapper;

        public MemberBL(IMemberDAL memberDAL)
        {

            _memberDAL = memberDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<MemberDTO> GetAllMembers()
        {

            List<Member> members = _memberDAL.GetAllMembers();

            return mapper.Map<List<Member>, List<MemberDTO>>(members);

        }
        public MemberDTO getMemberById(int memberId)
        {
            Member Member = _memberDAL.getMemberById(memberId);
            return mapper.Map<Member, MemberDTO>(Member);
        }
        public MemberDTO getMemberByTz(string tz)
        {
            Member Member = _memberDAL.getMemberByTz(tz);
            return mapper.Map<Member, MemberDTO>(Member);
        }
        public int GetUnvaccinatedMembers()
        {
            return _memberDAL.GetUnvaccinatedMembers();
        }
        public int GetSicksPerMonth(int month)
        {
            return _memberDAL.GetSicksPerMonth(month);
        }
        public bool AddMember(MemberDTO member)
        {
            return _memberDAL.AddMember(mapper.Map<MemberDTO, Member>(member));
        }

        public bool DeleteMember(int id)
        {
            return _memberDAL.DeleteMember(id);
        }

        public bool UpdateMember(MemberDTO Member, int id)
        {
            return _memberDAL.UpdateMember(mapper.Map<MemberDTO, Member>(Member), id);
        }
    }

}
