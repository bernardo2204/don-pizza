const http = require("http");
const fs = require("fs");
const path = require("path");
const mime = {".html":"text/html",".css":"text/css",".js":"text/javascript",".webp":"image/webp",".json":"application/json",".jpg":"image/jpeg",".jpeg":"image/jpeg",".png":"image/png"};
const root = process.cwd();
http.createServer((req,res)=>{
  let p = decodeURIComponent(req.url.split("?")[0]);
  let fp = path.join(root, p === "/" ? "/index.html" : p);
  fs.readFile(fp, (err,data)=>{
    if (err) {
      const alt = path.join(root, "..", p);
      fs.readFile(alt, (err2,data2)=>{
        if (err2) { res.writeHead(404); res.end("not found"); return; }
        res.writeHead(200,{"Content-Type": mime[path.extname(alt)]||"application/octet-stream"});
        res.end(data2);
      });
      return;
    }
    res.writeHead(200,{"Content-Type": mime[path.extname(fp)]||"application/octet-stream"});
    res.end(data);
  });
}).listen(8099, ()=>console.log("servidor no ar"));
