using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patient_In_Pathway.Models
{
    public class DataAccess
    {
        MongoClient _client;
        //MongoServer _server;
        IMongoDatabase _db;

        public DataAccess()
        {
            _client = new MongoClient("mongodb://127.0.0.1:27017");
            //_client = new MongoClient("mongodb://127.0.0.1:52212");
            _db = _client.GetDatabase("ProstateCancerPathway");
        }
        public IEnumerable<Patient> GetPatients()
        {
            var filter = new BsonDocument();

            return _db.GetCollection<Patient>("Patients").Find(filter).ToList();

        }

        //public  async System.Threading.Tasks.Task<Patient> GetPatient(ObjectId id)
        //{


        //    var collection = _db.GetCollection<Patient>("Patients");
        //    var filter = Builders<Patient>.Filter.Eq(p => p.Id, id);
        //    //return _db.GetCollection<Patient>("Patients").Find(res);
        //    var list = await collection.Find(filter).FirstOrDefaultAsync();
        //    //return _db.GetCollection<Patient>("Patients").Find(res);        
        //    return list;

        //}

        public async System.Threading.Tasks.Task<Patient> GetPatient(string LastName)
        {


            var collection = _db.GetCollection<Patient>("Patients");
            var filter = Builders<Patient>.Filter.Eq("LastName", LastName);
            //return _db.GetCollection<Patient>("Patients").Find(res);
            var list = await collection.Find(filter).FirstOrDefaultAsync();
            //return _db.GetCollection<Patient>("Patients").Find(res);        
            return list;

        }

        public async System.Threading.Tasks.Task<Patient> GetPatient(string category, int id)
        {


            var collection = _db.GetCollection<Patient>("Patients");
            var filter = Builders<Patient>.Filter.Eq("Category", category);
            //return _db.GetCollection<Patient>("Patients").Find(res);
            var list = await collection.Find(filter).FirstOrDefaultAsync();
            //return _db.GetCollection<Patient>("Patients").Find(res);        
            return list;

        }



        public async System.Threading.Tasks.Task<Patient> Create(Patient p)
        //public void Create(Patient p)
        {
            await _db.GetCollection<Patient>("Patients").InsertOneAsync(p);

            return p;

        }

        //public void Update(ObjectId id, Patient p)
        //{
        //    p.Id = id;
        //    var res = Query<Patient>.EQ(pd => pd.Id, id);
        //    var operation = Update<Patient>.Replace(p);
        //    _db.GetCollection<Patient>("Patients").Update(res, operation);
        //}
        //public async void Remove(ObjectId Patientid)
        //{
        //    var collection = _db.GetCollection<Patient>("Patients");
        //    var filter = Builders<Patient>.Filter.Eq(p=> p.Id, Patientid);
        //    //var res = Query<Patient>.EQ(e => e.Id, id);
        //    var operation = await _db.GetCollection<Patient>("Patients").DeleteOneAsync(filter);
        //}

    }
}