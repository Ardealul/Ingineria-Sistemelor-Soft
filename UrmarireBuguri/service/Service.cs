using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrmarireBuguri.domain;
using UrmarireBuguri.repo;

namespace UrmarireBuguri.service
{
    public class Service
    {
        private BugRepo BugRepo;
        private ProgramatorRepo ProgramatorRepo;
        private VerificatorRepo VerificatorRepo;

        public Service(BugRepo bugRepo, ProgramatorRepo programatorRepo, VerificatorRepo verificatorRepo)
        {
            BugRepo = bugRepo;
            ProgramatorRepo = programatorRepo;
            VerificatorRepo = verificatorRepo;
        }

        //BugRepo
        public void deleteBug(int id)
        {
            BugRepo.delete(id);
        }

        public void addBug(int id, string denumire, string descriere)
        {
            BugRepo.add(id, denumire, descriere);
        }

        public IList<Bug> findAllBug()
        {
            IList<Bug> bugList = new List<Bug>();
            foreach (Bug bug in BugRepo.findAll())
            {
                bugList.Add(bug);
            }
            return bugList;
        }

        public Bug findOneBug(int id)
        {
            return BugRepo.findOne(id);
        }


        //ProgramatorRepo
        public void deleteProgramator(string username, string password)
        {
            ProgramatorRepo.delete(username, password);
        }

        public void addProgramator(int id, string username, string password)
        {
            ProgramatorRepo.add(id, username, password);
        }

        public IList<Programator> findAllProgramator()
        {
            IList<Programator> programatorList = new List<Programator>();
            foreach (Programator programator in ProgramatorRepo.findAll())
            {
                programatorList.Add(programator);
            }
            return programatorList;
        }

        public Programator findOneProgramator(string username, string password)
        {
            return ProgramatorRepo.findOne(username, password);
        }

        public void updateProgramator(int id, string username, string password)
        {
            ProgramatorRepo.update(id, username, password);
        }


        //VerificatorRepo
        public void deleteVerificator(string username, string password)
        {
            VerificatorRepo.delete(username, password);
        }

        public void addVerificator(int id, string username, string password)
        {
            VerificatorRepo.add(id, username, password);
        }

        public IList<Verificator> findAllVerificator()
        {
            IList<Verificator> verificatorList = new List<Verificator>();
            foreach (Verificator verificator in VerificatorRepo.findAll())
            {
                verificatorList.Add(verificator);
            }
            return verificatorList;
        }

        public Verificator findOneVerificator(string username, string password)
        {
            return VerificatorRepo.findOne(username, password);
        }

        public void updateVerificator(int id, string username, string password)
        {
            VerificatorRepo.update(id, username, password);
        }
    }
}
