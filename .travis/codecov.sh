#!/usr/bin/env bash
curl -s https://codecov.io/bash > codecov
chmod +x codecov
./codecov -f "../DomainCore.xml" -t CODECOV_TOKEN